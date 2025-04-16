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

        clsConexionBDAccess conn = new clsConexionBDAccess();
        clsConexionBD conexion = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmInicio_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbCategoriaA); llenarCombo(cmbCategoriaM);
            /*
            var controles = new[] { updCodigoA, updCodigoE, updCodigoM};

            foreach (var c in controles)
            {
                c.Minimum = 1;
                c.Maximum = 100;
            }*/
            updCodigoA.Maximum = 100; updCodigoE.Maximum = 100; updCodigoE.Minimum = 1;

            updStockA.Maximum = 1000; updStockM.Maximum = 1000;
            updPrecioA.Maximum = 10000; updPrecioM.Maximum = 10000;
            dgvProductos.ReadOnly = true;

            conexion.cargarLista(lstProductos);  // Con Access -----> conn.cargarLista(lstProductos);
            conexion.obtenerDatos(dgvProductos); // Con Access -----> conn.obtenerDatos(dgvProductos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (updCodigoA.Value != 0)
            {
                if (camposVacios(txtNombreA, txtDescripcionA, cmbCategoriaA) != true) //Verificamos que no hayan campos vacios
                {
                    int cod = Convert.ToInt32(updCodigoA.Value); int stock = Convert.ToInt32(updStockA.Value);
                    string nom = txtNombreA.Text; string desc = txtDescripcionA.Text;
                    double precio = Convert.ToDouble(updPrecioA.Value);
                    string cat = cmbCategoriaA.Text;

                    if (codRepetido(cod) != true) //Verificamos que el codigo no exista en la base de datos/lista
                    {
                        if (precio > 0) //Verificamos que el producto no sea gratis viste
                        {
                            clsProducto nuevo = new clsProducto(cod, nom, desc, precio, stock, cat);

                            conexion.agregarProducto(nuevo); //Con Access-----> conn.agregarProducto(nuevo);
                            lstProductos.agregarProducto(nuevo); conexion.obtenerDatos(dgvProductos);

                            restablecerValores(updCodigoA, txtNombreA, txtDescripcionA, updPrecioA, updStockA, cmbCategoriaA);
                            MessageBox.Show("El producto fue añadido con exito.", "✅ CARGA EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("El precio del producto debe valer más de 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("El codigo del producto NO puede ser 0.","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (camposVacios(txtNombreM, txtDescripcionM, cmbCategoriaM) != true)
            {
                //Verificamos que el producto exista mediante el codigo ingresado
                int cod = Convert.ToInt32(updCodigoM.Value);
                bool existe = false;
                lstProductos.lstProductos.ForEach(elem =>
                {
                    if (cod == elem.codigo) existe = true;
                });
                //Si el producto existe o no, se procede con los siguientes controles
                if (existe != false)
                {
                    int stock = Convert.ToInt32(updStockM.Value);
                    string nom = txtNombreM.Text; string desc = txtDescripcionM.Text;
                    double precio = Convert.ToDouble(updPrecioM.Value);
                    string cat = cmbCategoriaM.Text;

                    if (precio > 0)
                    {
                        //Conseguimos el producto existente para poder aplicar las nuevas modificaciones
                        clsProducto aux = lstProductos.lstProductos.Find(elem => elem.codigo.Equals(cod));

                        aux.nombre = nom; aux.descripcion = desc; aux.precio = precio;
                        aux.stock = stock; aux.categoria = cat;

                        conexion.actualizarProducto(aux); //Con Access ---> conn.actualizarProducto(aux);
                        lstProductos.lstProductos.Clear();
                        conexion.obtenerDatos(dgvProductos); conexion.cargarLista(lstProductos);

                        restablecerValores(updCodigoM, txtNombreM, txtDescripcionM, updPrecioM, updStockM, cmbCategoriaM);
                        MessageBox.Show("El producto fue modificado con exito.", "🔄 MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("El precio del producto debe valer más de 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("El producto que intenta modiicar no se encuentra en la Base de Datos (El codigo no existe).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codEliminar = Convert.ToInt32(updCodigoE.Value);
            string nomProducto = "";
            bool existe = false;

            //Busqueda del producto
            lstProductos.lstProductos.ForEach(elem =>
            {
                if (codEliminar == elem.codigo)
                {
                    existe = true;
                    nomProducto = elem.nombre;
                }
            });

            if (existe != false)
            {
                DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea eliminar el producto '{nomProducto}' (Código: {codEliminar})?",
                    "CONFIRMAR ELIMINACIÓN",
                        MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2); // No como opción por defecto

                if (respuesta == DialogResult.Yes)
                {
                    conexion.eliminarProducto(codEliminar);

                    lstProductos.lstProductos.Clear();
                    conexion.obtenerDatos(dgvProductos); conexion.cargarLista(lstProductos);

                    updCodigoE.Value = 1;
                    MessageBox.Show($"El producto ({nomProducto}) fue eliminado con exito.", "❌ ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("El producto que intenta eliminar NO existe en la Base de Datos (Codigo no encontrado).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpiarA_Click(object sender, EventArgs e)
        {
            restablecerValores(updCodigoA, txtNombreA, txtDescripcionA, updPrecioA, updStockA, cmbCategoriaA);
        }

        private void btnLimpiarM_Click(object sender, EventArgs e)
        {
            restablecerValores(updCodigoM, txtNombreM, txtDescripcionM, updPrecioM, updStockM, cmbCategoriaM);
            habilitarBotonModificar();
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

        public bool codRepetido(int cod)
        {
            bool respuesta = false;

            lstProductos.lstProductos.ForEach(elem =>
            {
                if (cod == elem.codigo)
                {
                    respuesta = true;
                    MessageBox.Show("El codigo que intenta ingresar ya fue asignado a otro producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            return respuesta;
        }

        public bool camposVacios(TextBox nom, TextBox desc, ComboBox cat)
        {
            bool respuesta = false;

            if (nom.Text == "" || desc.Text == "" || cat.SelectedIndex == -1)
            {
                respuesta = true;
                MessageBox.Show("Hay campos sin completar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return respuesta;
        }

        public void restablecerValores(NumericUpDown cod, TextBox nom, TextBox desc, NumericUpDown precio, NumericUpDown stock, ComboBox cat)
        {
            cod.Value = 0;
            nom.Text = "";
            desc.Text = "";
            precio.Value = 0;
            stock.Value = 0;
            cat.SelectedIndex = -1;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el click no sea en el encabezado
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                //filaSeleccionada.Cells[0] ----> Debería de agarrar la columna donde DEBE estar el codigo del producto.

                //Verificamos que la fila seleccionada no este vacia (Como lo sería en el caso de la última).
                if (!string.IsNullOrWhiteSpace(filaSeleccionada.Cells[0].Value.ToString()))
                {
                    // Crear un array con la cantidad de celdas que tiene la fila / Crear variable de indice
                    string[] vecDatos = new string[filaSeleccionada.Cells.Count]; int i = 0;

                    // Recorrer cada celda y guardar su valor en el array
                    foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                    {
                        vecDatos[i] = celda.Value.ToString();
                        i++;
                    }

                    updCodigoM.Value = Convert.ToDecimal(vecDatos[0]); txtNombreM.Text = vecDatos[1];
                    txtDescripcionM.Text = vecDatos[2]; updPrecioM.Value = Convert.ToDecimal(vecDatos[3]);
                    updStockM.Value = Convert.ToDecimal(vecDatos[4]);

                    int indice = cmbCategoriaM.FindStringExact(vecDatos[5]); //<--- Devuelve el indice según el string dado por parametro.
                    cmbCategoriaM.SelectedIndex = indice;
                }
                else
                {
                    MessageBox.Show("Debe clickear en alguna de las filas donde se encuentra un producto para modificar.", "ERROR AL OBTENER DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    restablecerValores(updCodigoM, txtNombreM, txtDescripcionM, updPrecioM, updStockM, cmbCategoriaM);
                }
            }
            else
            {
                MessageBox.Show("Debe clickear en alguna de las filas donde se encuentra un producto para modificar.","ERROR AL OBTENER DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void habilitarBotonModificar()
        {
            if (updCodigoM.Value != 0 && txtNombreM.Text != "" && txtDescripcionM.Text != "" && updPrecioM.Value != 0 &&
                updStockM.Value != 0 && cmbCategoriaM.SelectedIndex != -1)
            {
                btnModificar.Enabled = true;
            } else btnModificar.Enabled = false;
        }

        private void updCodigoM_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotonModificar();
        }

        private void txtNombreM_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonModificar();
        }

        private void txtDescripcionM_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonModificar();
        }

        private void updPrecioM_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotonModificar();
        }

        private void updStockM_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotonModificar();
        }

        private void cmbCategoriaM_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotonModificar();
        }

    }
}
