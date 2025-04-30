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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        clsConexionBD conexion = new clsConexionBD();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nom = txtUsuario.Text;
            string contra = txtContraseña.Text;

            if (conexion.BuscarUsuario(nom, contra) == true)
            {
                frmInicio.ingresar = true;
                conexion.ConectarBD();
            }
        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar != true)
            {
                txtContraseña.UseSystemPasswordChar = true;
            } 
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }


    }
}
