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
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        clsConexionBD conexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmAgregarProducto_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (updCodigo.Value != 0)
            {
                if (camposVacios(txtNombre, txtDescripcion, cmbCategoria) != true) //Verificamos que no hayan campos vacios
                {
                    int cod = Convert.ToInt32(updCodigo.Value); int stock = Convert.ToInt32(updStock.Value);
                    string nom = txtNombre.Text; string desc = txtDescripcion.Text;
                    double precio = Convert.ToDouble(updPrecio.Value);
                    string cat = cmbCategoria.Text;

                    if (codRepetido(cod) != true) //Verificamos que el codigo no exista en la base de datos/lista
                    {
                        if (precio > 0) //Verificamos que el producto no sea gratis viste
                        {
                            clsProducto nuevo = new clsProducto(cod, nom, desc, precio, stock, cat);

                            conexion.agregarProducto(nuevo);
                            lstProductos.agregarProducto(nuevo); conexion.obtenerDatos(dgvProductos);

                            restablecerValores();
                            MessageBox.Show("El producto fue añadido con exito.", "✅ CARGA EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombre.Focus();
                        }
                        else MessageBox.Show("El precio del producto debe valer más de 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("El codigo del producto NO puede ser 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //-------------------------------------------------------------------------------------------------------------------
        public void llenarCombo(ComboBox cmb)
        {
            cmb.Items.Clear();
            string[] categorias = new string[] { "Electronicos", "Alimentos", "Bazar/Librería", "Limpieza", "Perfumes" };

            foreach (string cat in categorias)
            {
                cmb.Items.Add(cat);
            }
        }

        public bool codRepetido(int cod)
        {
            bool respuesta = false;

            lstProductos.lstProductos.ForEach(elem =>
            {
                if (cod == elem.codigo)
                {
                    respuesta = true;
                    MessageBox.Show("El codigo que intenta ingresar ya fue asignado a otro producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            return respuesta;
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

                btnAgregar.Enabled = true; btnAgregar.BackColor = Color.MediumSpringGreen;
            }
            else
            {
                btnAgregar.Enabled = false; btnAgregar.BackColor = Color.LightGray;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
