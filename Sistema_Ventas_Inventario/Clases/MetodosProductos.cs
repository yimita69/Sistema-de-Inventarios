using Sistema_Ventas_Inventario.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Ventas_Inventario.Clases
{
    internal class MetodosProductos
    {
        SqlDataReader resultado;
        DataTable tabla;
        SqlConnection sqlConexion;
        Producto producto;
        string nomProducto;

        internal DataTable ObtenerProductos()
        {
           
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ObtenerProductos", sqlConexion) { CommandType = CommandType.StoredProcedure };

                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla = new DataTable();
                tabla.Load(resultado);
                return tabla;
            }
            finally
            {
                if (sqlConexion != null && sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        public List<Proveedor> ObtenerProveedores()
        {
            var listaProveedores = new List<Proveedor>();
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ObtenerProveedores", sqlConexion) { CommandType = CommandType.StoredProcedure };

                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    listaProveedores.Add(new Proveedor(resultado.GetInt32(0), resultado.GetString(1)));
                }
                return listaProveedores;
            }
            finally
            {
                if (sqlConexion != null && sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        public string ValidarProducto(Producto producto)
        {
            if (producto == null) return "PRODUCTO NULO";
            if (string.IsNullOrWhiteSpace(producto.idProducto) ||
                string.IsNullOrWhiteSpace(producto.nomProducto) ||
                string.IsNullOrWhiteSpace(producto.stock) ||
                string.IsNullOrWhiteSpace(producto.precio) ||
                string.IsNullOrWhiteSpace(producto.descripcion) ||
                string.IsNullOrWhiteSpace(producto.idProveedor))
            {
                return "TE FALTA LLENAR Y/O SELECCIONAR UN CAMPO";
            }
            return "OK";
        }

        public string AgregarProducto(Producto producto)
        {
            string respuesta;
            try
            {

                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("InsertarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Conversión segura
                int stockInt;
                decimal precioDec;

                if (!int.TryParse(producto.stock, out stockInt))
                    return "EL STOCK DEBE SER UN NÚMERO ENTERO";

                if (!decimal.TryParse(producto.precio.Replace(",", "."), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out precioDec))
                    return "EL PRECIO DEBE SER UN NÚMERO DECIMAL";

                comando.Parameters.AddWithValue("@idProducto", producto.idProducto);
                comando.Parameters.AddWithValue("@nomProducto", producto.nomProducto);
                comando.Parameters.AddWithValue("@stock", stockInt);
                comando.Parameters.AddWithValue("@precio", precioDec);
                comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                comando.Parameters.AddWithValue("@idProveedor", Convert.ToInt32(producto.idProveedor));

                

                sqlConexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ?
                    "SE INSERTO CORRECTAMENTE" :
                    "NO SE PUDO INSERTAR EL REGISTRO";

                return respuesta;
            }
            finally
            {
                if (sqlConexion != null && sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();


            }

        }

        public string ActualizarProducto(Producto producto)
        {
            string respuesta;
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ActualizarProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;

                int stockInt;
                decimal precioDec;

                if (!int.TryParse(producto.stock, out stockInt))
                    return "EL STOCK DEBE SER UN NÚMERO ENTERO";

                if (!decimal.TryParse(producto.precio.Replace(",", "."), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out precioDec))
                    return "EL PRECIO DEBE SER UN NÚMERO DECIMAL";

                comando.Parameters.AddWithValue("@id", producto.idProducto);
                comando.Parameters.AddWithValue("@nomProducto", producto.nomProducto);
                comando.Parameters.AddWithValue("@stock", stockInt);
                comando.Parameters.AddWithValue("@precio", precioDec);
                comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                comando.Parameters.AddWithValue("@idProveedor", Convert.ToInt32(producto.idProveedor));

                sqlConexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ?
                    "SE ACTUALIZO CORRECTAMENTE" :
                    "NO SE PUDO ACTUALIZAR EL REGISTRO";

                return respuesta;
            }
            finally
            {
                if (sqlConexion != null && sqlConexion.State == ConnectionState.Open)
                    sqlConexion.Close();
            }
        }

        internal DataTable BuscarProducto(string productoBuscar)
        {
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("BuscarProducto", sqlConexion) { CommandType = CommandType.StoredProcedure };
                comando.Parameters.AddWithValue("@producto", productoBuscar.Trim());

                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla = new DataTable();
                tabla.Load(resultado);
                return tabla;
            }
            finally
            {
                if (sqlConexion != null && sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        internal Producto BuscarProductoVenta(string codigo)
        {
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("BuscarProductoVenta", sqlConexion) { CommandType = CommandType.StoredProcedure };
                comando.Parameters.AddWithValue("@codigo", codigo.Trim());

                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                producto = null;
                while (resultado.Read())
                {
                    producto = new Producto(
                        resultado.GetString(0), // id
                        resultado.GetString(1), // nombre
                        resultado.GetInt32(2).ToString(), // stock -> string en modelo
                        resultado.GetDecimal(3).ToString("0.00"), // precio -> string en modelo
                        resultado.IsDBNull(4) ? string.Empty : resultado.GetString(4),
                        "" // idProveedor no provisto por este SP
                    );
                }
                return producto;
            }
            finally
            {
                if (sqlConexion != null && sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }

        internal string ObtenerNombreProducto(string codigo)
        {
            try
            {
                sqlConexion = ConexionDB.ObtenerConexion();
                SqlCommand comando = new SqlCommand("ObtenerNombreProducto", sqlConexion) { CommandType = CommandType.StoredProcedure };
                comando.Parameters.AddWithValue("@codigo", codigo.Trim());

                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                nomProducto = string.Empty;
                while (resultado.Read())
                {
                    nomProducto = resultado.GetString(1); // segundo campo nomProducto según SP
                }
                return nomProducto;
            }
            finally
            {
                if (sqlConexion != null && sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
            }
        }
    }
}
