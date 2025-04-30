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

        clsConexionBD conexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();
        static public bool ingresar = false;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }

        public void ocultarSubMenu()
        {
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }

        public void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form formActivo = null;
        private void abrirFormulario(Form formulario)
        {
            if (formActivo != null) //Si exite un formulario activo, se cierra
            {
                formActivo.Close();
            }
            formActivo = formulario; //Se almacena el formulario activo
            formulario.TopLevel = false; //Indica que el formulario no es de nivel superior
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formulario);
            panelFormularios.Tag = formulario; //Asocia el form con el panel "contenedor"
            formulario.BringToFront();
            formulario.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmLogin());

            ocultarSubMenu();
        }

        private void btnGestionInventario_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenu);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (ingresar != false)
            {
                abrirFormulario(new frmAgregarProducto());

                ocultarSubMenu();
            }
            else 
                MessageBox.Show("Debe ingresar antes de poder utilizar el programa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (ingresar != false)
            {
                abrirFormulario(new frmModificarProducto());

                ocultarSubMenu();
            }
            else
                MessageBox.Show("Debe ingresar antes de poder utilizar el programa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (ingresar != false)
            {
                abrirFormulario(new frmEliminarProducto());

                ocultarSubMenu();
            }
            else
                MessageBox.Show("Debe ingresar antes de poder utilizar el programa.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mayder1014");
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
