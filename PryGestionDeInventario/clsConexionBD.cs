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

        //static public clsConexionBD conexion;

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

        #region Tabla Productos

        public void obtenerDatos(DataGridView dgv)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

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
                    col.SortMode = DataGridViewColumnSortMode.NotSortable; //Esto evita que la columna se pueda ordenar al clickearla.
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

                //Empieza a llenar la lista con los valores correspondientes de un producto fila por fila.
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
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void agregarProducto(clsProducto producto)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

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

        #endregion

        #region Tabla Usuarios

        public clsUsuario BuscarUsuario(string nombre, string contraseña)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                conexionBaseDatos.Open();

                //Consulta para obtener todos los datos necesarios del usuario
                string query = "SELECT Id, Usuario, Contraseña, Estado, FechaUltimaConexion FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@Usuario", nombre);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) //Busca al usuario, si se encuentra se procede con las siguientes operaciones.
                    {
                        //Se consigue la contraseña para comparar posteriormente.
                        string contraseñaBD = reader["Contraseña"].ToString();

                        //Crea un usuario auxiliar para verificar las condiciones del mismo (Bloqueado, si el usuario es correcto pero la contraseña no, etc)
                        clsUsuario aux = new clsUsuario(Convert.ToInt32(reader["Id"]), reader["Usuario"].ToString(), reader["Contraseña"].ToString(),
                                Convert.ToInt32(reader["Estado"]), Convert.ToDateTime(reader["FechaUltimaConexion"]));

                        if (aux.estado != 0) //Si el usuario no esta bloqueado, se procede con las siguientes operaciones:
                        {
                            if (contraseñaBD == contraseña) //Si las contraseñas coinciden, se loguea -> intentos reseteados.
                            {
                                frmLogin.intentosRestantes = 3; frmLogin.lblAvisoIntentos.Visible = false;
                                return aux;
                            }
                            else //Si se encuentra al usuario pero la contraseña es incorrecta. Se le advierte de intentos y posible bloqueo
                            {
                                frmLogin.intentosRestantes--; frmLogin.lblAvisoIntentos.Visible = true;
                                frmLogin.lblAvisoIntentos.Text = $"INTENTOS RESTANTES: {frmLogin.intentosRestantes}";

                                if (frmLogin.intentosRestantes > 0) //Si aún le quedan intentos, se le advierte los intentos restantes.
                                {
                                    MessageBox.Show("Contraseña incorrecta. Si agota sus intentos el usuario será bloqueado.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else //Si el usuario agotó sus intentos. Se procede a bloquearlo y notificarselo.
                                {
                                    aux.estado = 0;
                                    actualizarUsuario(aux);
                                    MessageBox.Show("El usuario ha sido bloqueado.", "INTENTOS AGOTADOS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                            }
                        }
                        else //Si el usuario ya se encuentra bloqueado, se le notifica al usuario.
                        {
                            MessageBox.Show("El usuario se encuentra bloqueado.", "USUARIO BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else //Si de primeras no se encuentra o no existe el usuario, se le dice sin realizar ninguna otra acción.
                    {
                        MessageBox.Show("Usuario no encontrado. Verifique que haya escrito correctamente.", "USUARIO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message);
            }

            return null; //Retorna null si no se encuentra el usuario o no coincide la contraseña.
        }

        public List<clsUsuario> cargarListaUsuariosBloqueados()
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios WHERE Estado = 0";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable
                DataTable tablaUsuarios = new DataTable();

                //Llenar el DataTable
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaUsuarios.Load(reader);
                }

                if (tablaUsuarios != null) //Si se encontraron usuarios bloqueados y se cargaron en el DataTable...
                {
                    List<clsUsuario> lstUsuarios = new List<clsUsuario>();

                    foreach (DataRow fila in tablaUsuarios.Rows)
                    {
                        clsUsuario usuario = new clsUsuario(Convert.ToInt32(fila[0]), fila[1].ToString(), fila[2].ToString(),
                            Convert.ToInt32(fila[3]), Convert.ToDateTime(fila[4]));

                        lstUsuarios.Add(usuario);
                    }
                    return lstUsuarios; //Retorna la lista de usuarios bloqueados e ignora el return del final.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null; //Retornará null si no existen usuarios bloqueados.
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

        #endregion
    }
}
