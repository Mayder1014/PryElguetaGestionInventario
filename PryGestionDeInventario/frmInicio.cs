using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionDeInventario
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        clsConexionBD conn = new clsConexionBD();
        private void frmInicio_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbCategoriaA); llenarCombo(cmbCategoriaM);
            var controles = new[] { updCodigoA, updCodigoM, updCodigoE };

            foreach (var c in controles)
            {
                c.Minimum = 1;
                c.Maximum = 100;
            }

            updStockA.Minimum = 1; updStockA.Maximum = 1000;
            updStockM.Maximum = 1000;

            conn.obtenerDatos(dgvProductos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        //METODOS -------------------------------------------------------------------------------------------
        public void llenarCombo(ComboBox cmb)
        {
            cmb.Items.Clear();
            string[] categorias = new string[] { "Electronicos", "Alimentos", "Bazar/Librería", "Limpieza", "Perfumes" };

            foreach (string cat in categorias)
            {
                cmb.Items.Add(cat);
            }
        }
    }
}
