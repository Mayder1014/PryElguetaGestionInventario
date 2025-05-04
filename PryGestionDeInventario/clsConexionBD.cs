using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;

namespace PryGestionDeInventario
{
    public class clsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=Tienda;Trusted_Connection=True;";

        //conector
        SqlConnection conexionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        static public clsConexionBD conexion;

        public void ConectarBD()
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                MessageBox.Show($"Conexión a base de datos: {nombreBaseDeDatos}.", "CONEXIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }
        }

        public clsUsuario BuscarUsuario(string nombre, string contraseña)
        {
            try
            {
                using (conexionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    conexionBaseDatos.Open();

                    // Consulta para obtener todos los datos necesarios del usuario
                    string query = "SELECT Id, Usuario, Contraseña, Estado, FechaUltimaConexion FROM Usuarios WHERE Usuario = @Usuario AND Estado = 1";

                    SqlCommand cmd = new SqlCommand(query, conexionBaseDatos);
                    cmd.Parameters.AddWithValue("@Usuario", nombre);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Verificar contraseña (deberías usar hash en producción)
                            string contraseñaBD = reader["Contraseña"].ToString();

                            if (contraseñaBD == contraseña)
                            {
                                // Crear y devolver el objeto usuario con los datos
                                return new clsUsuario(Convert.ToInt32(reader["Id"]), reader["Usuario"].ToString(), reader["Contraseña"].ToString(),
                                    Convert.ToInt32(reader["Estado"]), Convert.ToDateTime(reader["FechaUltimaConexion"]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
            }

            return null; // Retorna null si no se encuentra o no coincide la contraseña
        }

        /*
        public bool BuscarUsuario(string nombre, string contraseña)
        {
            bool usuarioValido = false;

            try
            {
                using (conexionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    conexionBaseDatos.Open();

                    string query = "SELECT Contraseña FROM Usuarios WHERE Usuario = @Usuario AND Estado = 1";
                    SqlCommand cmd = new SqlCommand(query, conexionBaseDatos);
                    cmd.Parameters.AddWithValue("@Usuario", nombre);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string contraseñaBD = resultado.ToString();

                        // Comparar contraseñas (si están cifradas, deberías usar un método como BCrypt o SHA256 aquí)
                        if (contraseñaBD == contraseña) // ¡OJO! No recomendable si las contraseñas están en texto plano
                        {
                            usuarioValido = true;
                            // Aquí también podrías actualizar la fecha de última conexión
                        }
                        else
                        {
                            
                            MessageBox.Show("Contraseña incorrecta.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
            }

            if (usuarioValido != false)
            {
                MessageBox.Show("Bienvenido " + nombre + ".");
            }

            return usuarioValido;
        }
        */
        public void cargarUsuarios(List<clsUsuario> lstUsuarios)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable
                DataTable tablaUsuarios = new DataTable();

                //Llenar el DataTable
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaUsuarios.Load(reader);
                }

                foreach (DataRow fila in tablaUsuarios.Rows)
                {
                    clsUsuario usuario = new clsUsuario(Convert.ToInt32(fila[0]), fila[1].ToString(), fila[2].ToString(),
                        Convert.ToInt32(fila[3]), Convert.ToDateTime(fila[4]));

                    lstUsuarios.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void actualizarUsuario(clsUsuario usuario)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string updateQuery = "UPDATE Usuarios SET Usuario = @usuario, Contraseña = @contraseña, " +
                    "Estado = @estado, FechaUltimaConexion = @ultConexion WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(updateQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@id", usuario.Id);
                cmd.Parameters.AddWithValue("@usuario", usuario.usuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                cmd.Parameters.AddWithValue("@estado", usuario.estado);
                cmd.Parameters.AddWithValue("@ultConexion", usuario.ultConexion);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void obtenerDatos(DataGridView dgv)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Productos";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }

                //Mostrar en grilla
                dgv.DataSource = tablaProductos;
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void cargarLista(clsProductos lista)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Productos";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }

                foreach (DataRow fila in tablaProductos.Rows)
                {
                    clsProducto prod = new clsProducto(Convert.ToInt32(fila[0]), fila[1].ToString(), fila[2].ToString(),
                        Convert.ToDouble(fila[3]), Convert.ToInt32(fila[4]), fila[5].ToString()); ;

                    lista.lstProductos.Add(prod);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void agregarProducto(clsProducto producto)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string insertQuery = "INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock, Categoria) VALUES " +
                    "(@codigo, @nombre, @descripcion, @precio, @stock, @categoria)";
                SqlCommand cmd = new SqlCommand(insertQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@codigo", producto.codigo);
                cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.precio);
                cmd.Parameters.AddWithValue("@stock", producto.stock);
                cmd.Parameters.AddWithValue("@categoria", producto.categoria);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void actualizarProducto(clsProducto producto)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string updateQuery = "UPDATE Productos SET Nombre = @nombre, Descripcion = @descripcion, " +
                    "Precio = @precio, Stock = @stock, Categoria = @categoria WHERE Codigo = @codigo";
                SqlCommand cmd = new SqlCommand(updateQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@codigo", producto.codigo);
                cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.precio);
                cmd.Parameters.AddWithValue("@stock", producto.stock);
                cmd.Parameters.AddWithValue("@categoria", producto.categoria);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void eliminarProducto(int codEliminar)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string deleteQuery = "DELETE FROM Productos WHERE Codigo = @codigo";
                SqlCommand cmd = new SqlCommand(deleteQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@codigo", codEliminar);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

    }
}
