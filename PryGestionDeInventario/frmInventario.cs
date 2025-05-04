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
        private void frmInventario_Load(object sender, EventArgs e)
        {
            clsTemas.AplicarTema(this);

            llenarCombo(cmbIngresar);
            dgvProductos.ReadOnly = true;
            conexion.obtenerDatos(dgvProductos);
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
    }
}
