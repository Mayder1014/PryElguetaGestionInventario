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

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            clsTemas.AplicarTema(this);

            if (clsTemas.esTemaOscuro == true)
            {
                optTemaOscuro.Checked = true;
            }
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

            // Cambiar color del panel principal
            formularioPrincipal.panelContenedor.BackColor = Color.FromArgb(60, 60, 60); // Gris oscuro
        }

        private void optTemaClaro_CheckedChanged(object sender, EventArgs e)
        {
            clsTemas.esTemaOscuro = false;
            // Cambiar color del panel principal
            formularioPrincipal.panelContenedor.BackColor = SystemColors.Control;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
