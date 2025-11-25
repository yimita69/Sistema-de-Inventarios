using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Ventas_Inventario.Clases
{
    public static class ConexionDB
    {
        private static string connectionString = "server=EDISON\\SQLEXPRESS; database=test235; integrated security=true";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
