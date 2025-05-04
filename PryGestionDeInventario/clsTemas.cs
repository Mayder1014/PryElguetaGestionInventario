using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionDeInventario
{
    public static class clsTemas
    {
        private static bool temaOscuro = false;

        public static bool esTemaOscuro
        {
            get => temaOscuro;
            set
            {
                if (temaOscuro != value)
                {
                    temaOscuro = value;
                    AplicarTemaAFormularios();
                }
            }
        }

        private static void AplicarTemaAFormularios()
        {
            foreach (Form form in Application.OpenForms)
            {
                AplicarTema(form);
            }
        }

        public static void AplicarTema(Form form)
        {
            if (esTemaOscuro)
            {
                // Tema oscuro
                form.BackColor = Color.FromArgb(60, 60, 60); // Gris oscuro
            }
            else
            {
                // Tema claro (valores por defecto)
                form.BackColor = SystemColors.Control;
            }
        }

    }
}
