using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        public void ConectarBD()
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }
        }

        public void obtenerDatos(DataGridView dgv)
        {
            try
            {
                ConectarBD();

                string query = "SELECT * FROM Productos";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }
                //ESTO SE EJECUTARA SOLO UNA VEZ --> Apenas se carga el formulario, la grilla estará vacia. De aquí en adelante se sobreescribira constantemente ya teniendo datos.
                if (dgv.Rows.Count == 0)
                    MessageBox.Show("Conexión a base de datos: " + nombreBaseDeDatos);
                
                //Mostrar en grilla
                dgv.DataSource = tablaProductos;
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
                ConectarBD();
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
                ConectarBD();

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
                ConectarBD();

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
                ConectarBD();

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
