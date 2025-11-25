using Sistema_Ventas_Inventario.Clases;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Ventas_Inventario.Clases
{
    public class MetodosProveedores
    {
        SqlDataReader resultado;
        DataTable tabla = new DataTable();
        SqlConnection sqlConexion;

        public DataTable ObtenerProveedores()
        {
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ObtenerProveedores", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;

                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla = new DataTable();
                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ObtenerProveedores(): " + ex.Message);
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }

        public string AgregarProveedor(Proveedor proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("InsertarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nomProveedor", proveedor.nomProveedor);
                comando.Parameters.AddWithValue("@numContacto", proveedor.numContacto);
                comando.Parameters.AddWithValue("@direccion", proveedor.direccion);
                comando.Parameters.AddWithValue("@email", proveedor.email);

                sqlConexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                    respuesta = "SE INSERTO CORRECTAMENTE";
                else
                    respuesta = "NO SE PUDO INSERTAR EL REGISTRO";

                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en AgregarProveedor(): " + ex.Message);
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }

        public DataTable BuscarProveedor(string nombre)
        {
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("BuscarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@proveedor", nombre.Trim());

                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                tabla = new DataTable();
                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BuscarProveedor(): " + ex.Message);
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }

        public string ValidarProveedor(Proveedor proveedor)
        {
            if (proveedor.nomProveedor.Equals("") ||
                proveedor.numContacto.Equals("") ||
                proveedor.direccion.Equals("") ||
                proveedor.email.Equals(""))
            {
                return "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            }

            return "OK";
        }

        public string ActualizarProveedor(int idProveedor, Proveedor proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ActualizarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", idProveedor);
                comando.Parameters.AddWithValue("@nomProveedor", proveedor.nomProveedor);
                comando.Parameters.AddWithValue("@numContacto", proveedor.numContacto);
                comando.Parameters.AddWithValue("@direccion", proveedor.direccion);
                comando.Parameters.AddWithValue("@email", proveedor.email);

                sqlConexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                    respuesta = "SE ACTUALIZO CORRECTAMENTE";
                else
                    respuesta = "NO SE PUDO ACTUALIZAR EL REGISTRO";

                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ActualizarProveedor(): " + ex.Message);
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }
    }
}

