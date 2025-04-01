using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionDeInventario
{
    public class clsConexionBD
    {
        // Definicion de comando, conexion y adaptador.

        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsConexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./BBDDProductos.accdb;";
        }

        public void obtenerDatos(DataGridView dgvProductos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Productos";

                DataTable tablaEmpleados = new DataTable();

                //foreach (DataRow fila in tablaEmpleados.Rows)
                //{

                //}

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaEmpleados);

                dgvProductos.DataSource = tablaEmpleados;
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
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Productos(Codigo, Nombre, Descripcion, Precio, Stock, Categoria) VALUES" +
                    $"('{producto.codigo}', '{producto.nombre}', '{producto.descripcion}', '{producto.precio}'," +
                    $"'{producto.stock}','{producto.nombre}')";

                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        /*
        public void actualizarProducto(clsProducto producto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"UPDATE Productos SET Nombre='{producto.nombre}', Descripcion='{producto.descripcion}' WHERE" +
                    $"Id = {usuario.ID}";

                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        */
    }
}
