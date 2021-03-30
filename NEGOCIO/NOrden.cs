using DATOS;
using Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NEGOCIO
{
    public class NOrden
    {
        OrdenD Conexion = new OrdenD();
        public void InserOrder(int ID_CLIENTE,String DIRECCIONENTREGA,int PRIORIDAD,double VALORTOTAL)
        {
            Conexion.InsertarOrden(ID_CLIENTE, DIRECCIONENTREGA, PRIORIDAD, VALORTOTAL);
        }
        public void InsertarDetalle(int NumOrd,string Producto,int Cantidad,double Valoruni,double Valor)
        {
            Conexion.InsertarDetalle(NumOrd,Producto,Cantidad,Valoruni,Valor);
        }
        public DataTable Mostrar(int Cliente)
        {
            DataTable Tabla = new DataTable();
            Tabla = Conexion.Mostrar(Cliente);

            return Tabla;
        }

        public DataTable DetalleOrden(int Cliente,int IDCABCERAR)
        {
            DataTable Tabla = new DataTable();
            Tabla = Conexion.MostrarDetalle(Cliente, IDCABCERAR);

            return Tabla;
        }

        public string NombreProducto(string Codigo)
        {
            string Nombre = Conexion.NombreProducto(Codigo);
            return Nombre;
        }
    }
}
