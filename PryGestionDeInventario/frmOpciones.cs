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
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
        }

        //Obtener referencia al frmInicio (Para modificar el panel contenedor de formularios)
        frmInicio formularioPrincipal = (frmInicio)Application.OpenForms["frmInicio"];
        clsConexionBD conexion = new clsConexionBD(); 
        List<clsUsuario> lstUsuarios;

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            clsTemas.AplicarTema(this);

            if (clsTemas.esTemaOscuro == true)
            {
                optTemaOscuro.Checked = true;
            }

            //Controles para que el admin (en caso de serlo) se le habilite una opción especial para desbloquear usuarios.
            if (frmInicio.logueado == true)
            {
                if (clsUsuario.usuarioActual.Id == 1) //Si el id = 1, es pq el logueado es el admin.
                {
                    lstUsuarios = conexion.cargarListaUsuariosBloqueados(); cargarComboBox();

                    if (lstUsuarios.Count > 0) //Si no existen usuarios bloqueados, no se mostrará nada.
                    {
                        lblInstruccionAdmin.Visible = true; mrcDesbloquearUsuarios.Visible = true;
                    }
                }
            }
        }

        #region Eventos

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optModoVentana_CheckedChanged(object sender, EventArgs e)
        {
            frmInicio.ActiveForm.WindowState = FormWindowState.Normal;
        }

        private void optPantallaCompleta_CheckedChanged(object sender, EventArgs e)
        {
            frmInicio.ActiveForm.WindowState = FormWindowState.Maximized;
        }

        private void optTemaOscuro_CheckedChanged(object sender, EventArgs e)
        {
            clsTemas.esTemaOscuro = true;
            //Cambiar color del panel principal, ya que el backColor para el frmInicio no se notaría.
            formularioPrincipal.panelContenedor.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void optTemaClaro_CheckedChanged(object sender, EventArgs e)
        {
            clsTemas.esTemaOscuro = false;
            formularioPrincipal.panelContenedor.BackColor = SystemColors.Control;
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            string usuarioADesbloquear = cmbUsuariosBloqueados.Text.Split('|')[0];
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que quiere desbloquear al usuario {usuarioADesbloquear}?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                var aux = lstUsuarios.Find(elem => elem.usuario.Equals(usuarioADesbloquear));
                if (aux != null)
                {
                    aux.estado = 1;
                    conexion.actualizarUsuario(aux);
                    MessageBox.Show($"El usuario {usuarioADesbloquear} ha sido desbloqueado con éxito.", "USUARIO DESBLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstUsuarios = conexion.cargarListaUsuariosBloqueados();
                    if (lstUsuarios.Count > 0)
                    {
                        cargarComboBox();
                    }
                    else
                    {
                        lblInstruccionAdmin.Visible = false; mrcDesbloquearUsuarios.Visible = false;
                        MessageBox.Show("¡No existen más usuarios a desbloquear! Cuando vuelva a haber usuarios bloqueados lo volverá a ver en esta sección.", "TODOS LOS USUARIOS DESBLOQUEADOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void cmbUsuariosBloqueados_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDesbloquear.Enabled = true;
            btnDesbloquear.Focus();
        }

        #endregion

        public void cargarComboBox()
        {
            lstUsuarios.ForEach(elem =>
            {
                cmbUsuariosBloqueados.Items.Add($"{elem.usuario}| Última conexión: {elem.ultConexion}");
            });
        }
    }
}
