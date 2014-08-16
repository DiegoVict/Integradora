using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;


namespace Datos.Conexion
{
    public class Conexion
    {
        SqlConnection conn;

        public SqlConnection getConexion()
        {
            string conexion = ConfigurationManager.ConnectionStrings["LiveThruConnection"].ConnectionString;
            conn = new SqlConnection(conexion);
            return conn;
        }
    }
}
