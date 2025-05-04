using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        static public bool logueado = false; //Variable que determinará cuando el usuario este logueado o no y pueda acceder a secciones del programa.
        public Panel panelContenedor;

        private void frmInicio_Load(object sender, EventArgs e)
        {
            clsTemas.AplicarTema(this);
            mostrarEstadoUsuario(clsUsuario.usuarioActual);
            panelContenedor = panelFormularios; 
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

        //Para visualizar el inventario, no se tiene ningun tipo de restricción, se haya logueado el usuario o no.
        private void btnVisualizarInventario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmInventario());

            ocultarSubMenu();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (permisoDeUsuario() != false)
            {
                abrirFormulario(new frmAgregarProducto());

                ocultarSubMenu();
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (permisoDeUsuario() != false)
            {
                abrirFormulario(new frmModificarProducto());

                ocultarSubMenu();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (permisoDeUsuario() != false)
            {
                abrirFormulario(new frmEliminarProducto());

                ocultarSubMenu();
            }
        }

        public bool permisoDeUsuario()
        {
            bool resultado = false;

            if (logueado != false)
            {
                resultado = true;
            }
            else
            {
                MessageBox.Show("Debe loguearse para poder tener acceder a esta sección", "ACCESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return resultado;
        }

        
        public void mostrarEstadoUsuario(clsUsuario usuario)
        {
            if (usuario != null)
            {
                lblEstadoUsuario.Text = usuario.usuario; lblUltConexion.Visible = true; 
                lblUltConexion.Text = $"Última conexión registrada: \r\n{usuario.ultConexion.ToString()}";
            }
            else
            {
                lblEstadoUsuario.Text = "Invitado"; lblUltConexion.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mayder1014");
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmOpciones());

            ocultarSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere salir del programa?", "CONFIRMAR SALIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
