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

        public static void AplicarTemaDgv(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is DataGridView dgv)
                {
                    if (esTemaOscuro)
                    {
                        dgv.EnableHeadersVisualStyles = false;

                        // Configuración para tema oscuro
                        dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                        dgv.BackgroundColor = Color.FromArgb(45, 45, 48);
                        dgv.GridColor = Color.White;

                        // Estilo de las celdas
                        dgv.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                        dgv.DefaultCellStyle.ForeColor = Color.White;
                        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 80, 80);
                        dgv.DefaultCellStyle.SelectionForeColor = Color.White;

                        // Estilo de los encabezados de columnas
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48);

                        // Estilo de los encabezados de filas
                        dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                        dgv.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Restaurar valores por defecto para tema claro
                        dgv.BackgroundColor = SystemColors.Window;
                        dgv.GridColor = SystemColors.ControlDark;

                        dgv.DefaultCellStyle.BackColor = SystemColors.Window;
                        dgv.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                        dgv.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                        dgv.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;

                        dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Control;

                        dgv.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                        dgv.RowHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                    }
                }
            }
        }

    }
}
