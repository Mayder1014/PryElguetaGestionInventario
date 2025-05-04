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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        clsConexionBD conexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            clsTemas.AplicarTema(this);

            llenarCombo(cmbCategoria);

            updCodigo.Maximum = 100; //updCodigoE.Maximum = 100; updCodigoE.Minimum = 1;
            updPrecio.DecimalPlaces = 2;
            updStock.Maximum = 1000; updPrecio.Maximum = 10000;

            dgvProductos.ReadOnly = true;
            conexion.cargarLista(lstProductos);
            conexion.obtenerDatos(dgvProductos);
            dgvProductos.ClearSelection();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (camposVacios(txtNombre, txtDescripcion, cmbCategoria) != true)
            {
                //Verificamos que el producto exista mediante el codigo ingresado
                int cod = Convert.ToInt32(updCodigo.Value);
                bool existe = false;
                lstProductos.lstProductos.ForEach(elem =>
                {
                    if (cod == elem.codigo) existe = true;
                });
                //Si el producto existe o no, se procede con los siguientes controles
                if (existe != false)
                {
                    int stock = Convert.ToInt32(updStock.Value);
                    string nom = txtNombre.Text; string desc = txtDescripcion.Text;
                    double precio = Convert.ToDouble(updPrecio.Value);
                    string cat = cmbCategoria.Text;

                    if (precio > 0)
                    {
                        //Conseguimos el producto existente para poder aplicar las nuevas modificaciones
                        clsProducto aux = lstProductos.lstProductos.Find(elem => elem.codigo.Equals(cod));

                        aux.nombre = nom; aux.descripcion = desc; aux.precio = precio;
                        aux.stock = stock; aux.categoria = cat;

                        conexion.actualizarProducto(aux);
                        lstProductos.lstProductos.Clear();
                        conexion.obtenerDatos(dgvProductos); conexion.cargarLista(lstProductos);

                        restablecerValores();
                        MessageBox.Show("El producto fue modificado con exito.", "🔄 MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("El precio del producto debe valer más de 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("El producto que intenta modiicar no se encuentra en la Base de Datos (El codigo no existe).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            restablecerValores();
            habilitarBoton();
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

        //----------------------------------------------------------------------------------------------------------------
        public void llenarCombo(ComboBox cmb)
        {
            cmb.Items.Clear();
            string[] categorias = new string[] { "Electronicos", "Alimentos", "Bazar/Librería", "Limpieza", "Perfumes" };

            foreach (string cat in categorias)
            {
                cmb.Items.Add(cat);
            }
        }

        //Este metodo basicamente no se ejecuta, al ser que los botones se deshabilitan cuando hay campos vacios
        public bool camposVacios(TextBox nom, TextBox desc, ComboBox cat)
        {
            bool respuesta = false;

            if (nom.Text == "" || desc.Text == "" || cat.SelectedIndex == -1)
            {
                respuesta = true;
                MessageBox.Show("Hay campos sin completar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return respuesta;
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
            if (updCodigo.Value != 0 && txtNombre.Text != "" && txtDescripcion.Text != "" && updPrecio.Value != 0 &&
                updStock.Value != 0 && cmbCategoria.SelectedIndex != -1)
            {

                btnModificar.Enabled = true; btnModificar.BackColor = Color.SteelBlue;
            }
            else
            {
                btnModificar.Enabled = false; btnModificar.BackColor = Color.LightGray;
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
