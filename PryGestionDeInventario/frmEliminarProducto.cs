using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionDeInventario
{
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }

        clsConexionBD conexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbCategoria);

            updCodigo.Maximum = 100; //updCodigoE.Maximum = 100; updCodigoE.Minimum = 1;
            updPrecio.DecimalPlaces = 2;
            updStock.Maximum = 1000; updPrecio.Maximum = 10000;
            updCodigo.Minimum = 1;

            dgvProductos.ReadOnly = true;
            conexion.cargarLista(lstProductos);
            conexion.obtenerDatos(dgvProductos);
            dgvProductos.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codEliminar = Convert.ToInt32(updCodigo.Value);
            string nomProducto = "";
            bool existe = false;

            //Busqueda del producto
            lstProductos.lstProductos.ForEach(elem =>
            {
                if (codEliminar == elem.codigo)
                {
                    existe = true;
                    nomProducto = elem.nombre;
                }
            });

            if (existe != false)
            {
                //Mensaje de advertencia / Confirmación para eliminar el producto.
                DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea eliminar el producto '{nomProducto}' (Código: {codEliminar})?",
                    "CONFIRMAR ELIMINACIÓN",
                        MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2); //No como opción por defecto

                if (respuesta == DialogResult.Yes)
                {
                    conexion.eliminarProducto(codEliminar);

                    lstProductos.lstProductos.Clear();
                    conexion.obtenerDatos(dgvProductos); conexion.cargarLista(lstProductos);

                    updCodigo.Value = 1;
                    MessageBox.Show($"El producto ({nomProducto}) fue eliminado con exito.", "❌ ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("El producto que intenta eliminar NO existe en la Base de Datos (Codigo no encontrado).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updCodigo_ValueChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void updPrecio_ValueChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void updStock_ValueChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            restablecerValores();
            habilitarBoton();
        }

        //-----------------------------------------------------------------------------------------------------------------
        public void llenarCombo(ComboBox cmb)
        {
            cmb.Items.Clear();
            string[] categorias = new string[] { "Electronicos", "Alimentos", "Bazar/Librería", "Limpieza", "Perfumes" };

            foreach (string cat in categorias)
            {
                cmb.Items.Add(cat);
            }
        }

        public void restablecerValores()
        {
            updCodigo.Minimum = 0; updCodigo.Value = 0;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            updPrecio.Value = 0;
            updStock.Value = 0;
            cmbCategoria.SelectedIndex = -1; cmbCategoria.Text = "Seleccionar categoría...";
        }

        public void habilitarBoton()
        {
            if (updCodigo.Value != 0)
            {
                btnEliminar.Enabled = true; btnEliminar.BackColor = Color.IndianRed;
            }
            else
            {
                btnEliminar.Enabled = false; btnEliminar.BackColor = Color.LightGray;
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificar que el click no sea en el encabezado (siendo RowIndex == -1 el encabezado)
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                //Crear un vector con la cantidad de celdas que tiene la fila / Crear variable de indice
                string[] vecDatos = new string[filaSeleccionada.Cells.Count]; int i = 0;

                //Recorrer cada celda de la fila y guardar su valor en el vector
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    vecDatos[i] = celda.Value.ToString();
                    i++;
                }

                updCodigo.Value = Convert.ToDecimal(vecDatos[0]); txtNombre.Text = vecDatos[1];
                txtDescripcion.Text = vecDatos[2]; updPrecio.Value = Convert.ToDecimal(vecDatos[3]);
                updStock.Value = Convert.ToDecimal(vecDatos[4]);

                int indice = cmbCategoria.FindStringExact(vecDatos[5]); //<--- Devuelve el indice del elemento del cmb que coincida con el string enviado por parametro.
                cmbCategoria.SelectedIndex = indice;
            }
            else
            {
                MessageBox.Show("Debe clickear en alguna de las filas donde se encuentra un producto para obtener los datos.", "ERROR AL OBTENER DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
