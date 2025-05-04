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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        clsConexionBD conexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmInventario_Load(object sender, EventArgs e)
        {
            clsTemas.AplicarTema(this); clsTemas.AplicarTemaDgv(this);

            llenarCombo(cmbIngresar);
            dgvProductos.ReadOnly = true;
            conexion.obtenerDatos(dgvProductos);
            conexion.cargarLista(lstProductos);

            cmbIngresar.SelectedIndex = 1; habilitarBoton();
        }

        public void llenarCombo(ComboBox cmb)
        {
            cmb.Items.Clear();
            string[] categorias = new string[] { "Electronicos", "Alimentos", "Bazar/Librería", "Limpieza", "Perfumes" };

            foreach (string cat in categorias)
            {
                cmb.Items.Add(cat);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (optBuscarCodigo.Checked)
            {
                int cod = Convert.ToInt32(updIngresar.Value);
                var aux = lstProductos.lstProductos.Find(elem => elem.codigo.Equals(cod));
                if (aux != null)
                {
                    dgvProductos.Columns.Clear();
                    agregarColumnas();
                    dgvProductos.Rows.Clear();
                    dgvProductos.Rows.Add(aux.codigo, aux.nombre, aux.descripcion, aux.precio, aux.stock, aux.categoria);
                }
                else MessageBox.Show("El codigo que intenta buscar no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cat = cmbIngresar.Text;
                if (cmbIngresar.SelectedIndex != -1)
                {
                    dgvProductos.Columns.Clear();
                    agregarColumnas();
                    dgvProductos.Rows.Clear();
                    lstProductos.lstProductos.ForEach(elem =>
                    {
                        if (elem.categoria.Equals(cat))
                        {
                            dgvProductos.Rows.Add(elem.codigo, elem.nombre, elem.descripcion, elem.precio, elem.stock, elem.categoria);
                        }
                    });
                }
                else MessageBox.Show("Debe elegir una categoria antes de filtrar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            dgvProductos.Columns.Clear();
            conexion.obtenerDatos(dgvProductos);
        }

        public void agregarColumnas()
        {
            dgvProductos.DataSource = null; string[] columnas = new string[] { "Codigo", "Nombre", "Descripcion", "Precio", "Stock", "Categoria" };
            foreach (string col in columnas)
            {
                dgvProductos.Columns.Add(col, col);
            }
        }

        public void habilitarBoton()
        {
            if (cmbIngresar.SelectedIndex != -1 && updIngresar.Value != 0)
            {
                btnFiltrar.Enabled = true;
            } else
            {
                btnFiltrar.Enabled = false;
            }
        }

        private void optFiltrarCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cmbIngresar.Visible = true; updIngresar.Visible = false;
            cmbIngresar.SelectedIndex = -1; updIngresar.Value = 1;
            habilitarBoton();
        }

        private void optBuscarCodigo_CheckedChanged(object sender, EventArgs e)
        {
            cmbIngresar.Visible = false; updIngresar.Visible = true;
            updIngresar.Value = 0; cmbIngresar.SelectedIndex = 1;
            habilitarBoton();
        }

        private void cmbIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void updIngresar_ValueChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }

        private void cmbIngresar_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBoton();
        }
    }
}
