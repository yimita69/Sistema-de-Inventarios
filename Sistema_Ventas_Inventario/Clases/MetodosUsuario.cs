using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_Ventas_Inventario.Clases
{
    public class MetodosUsuario
    {
        SqlDataReader resultado;
        DataTable tabla = new DataTable();
        SqlConnection sqlConexion = new SqlConnection();

        public DataTable ObtenerUsuarios()
        {
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ObtenerUsuarios", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }
        public List<Permiso> ObtenerPermisos()
        {
            List<Permiso> listaPermisos = new List<Permiso>();

            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ObtenerPermisos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaPermisos.Add(
                        new Permiso(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                        ));
                }

                return listaPermisos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public List<Estado> ObtenerEstados()
        {
            List<Estado> listaEstados = new List<Estado>();

            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ObtenerEstados", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    int idEstado = resultado.GetInt32(0); // idEstado
                    int estado = Convert.ToInt32(resultado["estado"]); // BIT -> 0 o 1
                    string descripcion = resultado.GetString(2); // descripcion

                    listaEstados.Add(new Estado(idEstado, estado, descripcion));
                }


                return listaEstados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }

        public string Validarusuario(Usuario usuario)
        {
            string resultado = null;
            if (usuario.nomUsuario.Equals("") || usuario.usuario.Equals("") || usuario.contrasena.Equals("") || usuario.idPermiso == 0 || usuario.idEstado == 0)
            {
                resultado = "Te faltan datos por llenar";
            }
            else
            {
                resultado = "OK";
            }
            return resultado;
        }

        public string AgregarUsuario(Usuario usuario)
        {
            string respuesta = "";

            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("InsertarUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nomUsuario", SqlDbType.NVarChar, 200).Value = usuario.nomUsuario;
                comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 50).Value = usuario.usuario;
                comando.Parameters.Add("@contrasena", SqlDbType.NVarChar, 10).Value = usuario.contrasena;
                comando.Parameters.Add("@idPermiso", SqlDbType.Int).Value = usuario.idPermiso;
                comando.Parameters.Add("@idEstado", SqlDbType.Int).Value = usuario.idEstado;

                sqlConexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "Se insertó correctamente";
                }
                else
                {
                    respuesta = "No se pudo insertar el registro";
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }

        public string ActualizarUsuario(int idUsuario, Usuario usuario)


        {
            string respuesta = "";
            try
            {

                sqlConexion = ConexionDB.ObtenerConexion();


                SqlCommand comando = new SqlCommand("ActualizarUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.Add("@id", SqlDbType.Int).Value = idUsuario;
                comando.Parameters.Add("@nomUsuario", SqlDbType.NVarChar, 200).Value = usuario.nomUsuario;
                comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 50).Value = usuario.usuario;
                comando.Parameters.Add("@contrasena", SqlDbType.NVarChar, 50).Value = usuario.contrasena;
                comando.Parameters.Add("@idPermiso", SqlDbType.Int).Value = usuario.idPermiso;
                comando.Parameters.Add("@idEstado", SqlDbType.Int).Value = usuario.idEstado;

                sqlConexion.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "Se actualizó correctamente";
                }
                else
                {
                    respuesta = "No se pudo actualizar el registro";
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }

        public DataTable BuscarUsuario(string nombre)
        {
            SqlConnection sqlConexion = null;
            SqlDataReader resultado = null;
            DataTable tabla = new DataTable();

            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("BuscarUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 200).Value = nombre.Trim();

                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
            }
            finally
            {
                if (resultado != null && !resultado.IsClosed)
                    resultado.Close();
                if (sqlConexion != null && sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }

            return tabla;
        }

        public Usuario LoginUsuario(string usuario, string contrasena)
        {
            Usuario user = null;

            try
            {
                sqlConexion = ConexionDB.ObtenerConexion(); 
                SqlCommand comando = new SqlCommand("LoginUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = usuario.Trim();
                comando.Parameters.Add("@pass", SqlDbType.NVarChar, 10).Value = contrasena.Trim();

                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                if (resultado.Read()) 
                {
                    user = new Usuario(
                        resultado.GetInt32(0),     
                        resultado.GetString(1),    
                        resultado.GetString(2),    
                        resultado.GetString(3),    
                        resultado.GetInt32(4),     
                        resultado.GetInt32(5)      
                    );
                }
                else
                {
                    user = new Usuario();
                    user.idUsuario = 0; 
                }

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar iniciar sesión: " + ex.Message);
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }

         
    }
}
    


