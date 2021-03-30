using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DATOS
{
    public class ConexionBD
    {
        private SqlConnection Conexion = new SqlConnection("Server=W10TESTDEV03;Database=PRUEBADESARROLLO;UID=sa;PWD=admin");
        public SqlConnection IniciarConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
