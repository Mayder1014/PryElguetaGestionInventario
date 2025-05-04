using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        frmInicio formPrincipal = Application.OpenForms["frmInicio"] as frmInicio; //Obtener referencia al formulario de Inicio
        clsConexionBD conexion = new clsConexionBD();
        static public int intentosRestantes = 3;
        static public Label lblAviso;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsTemas.AplicarTema(this);
            lblAviso = lblIntentos;

            txtContraseña.UseSystemPasswordChar = true; //Contraseña oculta por defecto.

            habilitarBotones();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nom = txtUsuario.Text;
            string contra = txtContraseña.Text;

            clsUsuario.usuarioActual = conexion.BuscarUsuario(nom, contra);

            if (clsUsuario.usuarioActual != null)
            {
                frmInicio.logueado = true; //El usuario logueado esta habilitado a acceder a todas las secciones.

                MessageBox.Show($"¡Bienvenido {nom}!", "LOGIN EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Clear(); txtContraseña.Clear();
                conexion.ConectarBD();

                formPrincipal.mostrarEstadoUsuario(clsUsuario.usuarioActual); //Se llama al metodo que actualiza el label del frmInicio (Nombre de Usuario)
                habilitarBotones();
            }
        }

        private void btnDesconectarse_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que quiere desconectarse? Pasará a ser Invitado y no tendra acceso a ciertas secciones.",
                "CONFIRMAR DESCONEXIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                frmInicio.logueado = false; //El usuario pasa a ser Invitado, y se le restringe el acceso a secciones del programa
                clsUsuario.usuarioActual.ultConexion = DateTime.Now; //Se establece la nueva "Ultima Conexión"
                conexion.actualizarUsuario(clsUsuario.usuarioActual); //Se procede a actualizar al usuario en la BBDD con la nueva "Ultima Conexión"

                clsUsuario.usuarioActual = null;
                MessageBox.Show("Se ha desconectado correctamente. Cambiando su estado a Invitado", "DESCONEXIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                formPrincipal.mostrarEstadoUsuario(clsUsuario.usuarioActual); //Se llama al metodo que actualiza el label del frmInicio (Nombre de Usuario)
                habilitarBotones();
            }
        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar != true)
            {
                txtContraseña.UseSystemPasswordChar = true;
                btnMostrarOcultar.Image = Properties.Resources.show;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
                btnMostrarOcultar.Image = Properties.Resources.hide;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        public void habilitarBotones()
        {
            if (frmInicio.logueado != false) //Se verifica que el usuario este logueado para habilitar el botón de desconexión.
            {
                btnDesconectarse.Enabled = true; btnIngresar.Enabled = false;
                lblMensajeDeAviso.Visible = true; lblMensajeDeAviso.Text = ">> No puede loguearse con otro usuario hasta que se desconecte con el usuario actual. <<";
            }
            else //Si el usuario no esta logueado, se habilita y deshabilita el boton de ingresar según lo siguiente...
            {
                lblMensajeDeAviso.Visible = false;
                btnDesconectarse.Enabled = false; btnIngresar.Enabled = true;
                if (txtUsuario.Text != "" && txtContraseña.Text != "")
                {
                    btnIngresar.Enabled = true;
                }
                else btnIngresar.Enabled = false;
            }

            if (btnIngresar.Enabled == false) btnIngresar.BackColor = SystemColors.ScrollBar;
            else btnIngresar.BackColor = SystemColors.Control;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
