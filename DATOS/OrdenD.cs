using Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class OrdenD
    {
        private ConexionBD Conexion = new ConexionBD();
        SqlCommand Comando = new SqlCommand();
        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        public void InsertarOrden(int ID_CLIENTE, string DIRECCIONENTREGA,int PRIORIDAD,double VALORTOTAL)
        {
            Comando.Connection = Conexion.IniciarConexion();
            Comando.CommandText = "SELECT MAX(CONSECUTIVO) CONSECUTIVO FROM ORDCABECERA";
            Leer = Comando.ExecuteReader();
            int NumOrd = 0;
            while (Leer.Read())
            {
                if(Leer["CONSECUTIVO"].ToString() == "")
                {
                    NumOrd = 1;
                }
                else
                {
                    NumOrd = Convert.ToInt32(Leer["CONSECUTIVO"]) + 1;
                }
            }
            Leer.Close();
            Comando.CommandText = "SELECT ID FROM CLIENTES WHERE IDENTIFICACION = "+ID_CLIENTE;
            Leer = Comando.ExecuteReader();
            int IdCliente = 0;
            while (Leer.Read())
            {
                IdCliente = Convert.ToInt32(Leer["ID"]);
            }
            Leer.Close();
            Comando.CommandText = "INSERT INTO ORDCABECERA VALUES (@CONSECUTIVO,@ID_CLIENTE,@FECHAREGISTRO,@DIRECCIONENTREGA,@ESTADO,@PRIORIDAD,@VALORTOTAL)";
            Comando.Parameters.AddWithValue("@CONSECUTIVO", NumOrd);
            Comando.Parameters.AddWithValue("@ID_CLIENTE", IdCliente);
            Comando.Parameters.AddWithValue("@FECHAREGISTRO", DateTime.Now);
            Comando.Parameters.AddWithValue("@DIRECCIONENTREGA", DIRECCIONENTREGA);
            Comando.Parameters.AddWithValue("@ESTADO", 0);
            Comando.Parameters.AddWithValue("@PRIORIDAD", PRIORIDAD);
            Comando.Parameters.AddWithValue("VALORTOTAL", VALORTOTAL);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.CommandText = "SELECT MAX(ID) ID FROM ORDCABECERA";
            Leer = Comando.ExecuteReader();
            int Id = 0;
            while (Leer.Read())
            {
                Id = Convert.ToInt32(Leer["ID"]);
            }
            DocumentoCache.NumOdr = Id;
            Conexion.CerrarConexion();
        }
        public DataTable Mostrar(int Cliente)
        {
            Comando.Connection = Conexion.IniciarConexion();
            Comando.CommandText = "select * from ORDCABECERA Where ID_CLIENTE = (SELECT ID FROM CLIENTES WHERE IDENTIFICACION = "+Cliente+")";
            Comando.CommandType = CommandType.Text;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Conexion.CerrarConexion();

            return Tabla;
        }

        public DataTable MostrarDetalle(int Cliente, int IDCABECERA)
        {
            Comando.Connection = Conexion.IniciarConexion();
            Comando.CommandText = "SELECT CODIGO,NOMBRE,CANTIDAD,VALORUNITARIOC,VALORPARCIALC FROM ORDDETALLE A INNER JOIN PRODUCTOS B ON B.ID = A.ID_PRODUCTO Where ID_ORDCABECERA ="+IDCABECERA;
            Comando.CommandType = CommandType.Text;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Conexion.CerrarConexion();

            return Tabla;
        }

        public string NombreProducto(string Codigo)
        {
            Comando.Connection = Conexion.IniciarConexion();
            Comando.CommandText = "SELECT NOMBRE FROM PRODUCTOS WHERE CODIGO = '"+Codigo+"'";
            Leer = Comando.ExecuteReader();
            string Nombre = null;
            while (Leer.Read())
            {
                Nombre = Leer["Nombre"].ToString();
            }
            Leer.Close();
            Conexion.CerrarConexion();
            return Nombre;
        }

        public void InsertarDetalle(int NumOrd,string Producto,int Cantidad,double Valoruni,double Valor)
        {
            Comando.Connection = Conexion.IniciarConexion();
            Comando.CommandText = "SELECT ID FROM PRODUCTOS WHERE CODIGO = '"+Producto+"'";
            Leer = Comando.ExecuteReader();
            int IdProduct = 0;
            while (Leer.Read())
            {
                IdProduct = Convert.ToInt32(Leer["ID"]);
            }
            Leer.Close();
            Comando.CommandText = "INSERT INTO ORDDETALLE VALUES(@IdCabe,@ID_PRODUCTO,@CANTIDAD,@VALORUNITARIOC,@VALORPARCIALC)";
            Comando.Parameters.AddWithValue("@IdCabe", NumOrd);
            Comando.Parameters.AddWithValue("@ID_PRODUCTO", IdProduct);
            Comando.Parameters.AddWithValue("@CANTIDAD", Cantidad);
            Comando.Parameters.AddWithValue("@VALORUNITARIOC",Valoruni);
            Comando.Parameters.AddWithValue("@VALORPARCIALC", Valor);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
        }
    }
}
