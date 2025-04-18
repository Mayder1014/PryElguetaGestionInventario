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
            //llenarCombo(cmbCategoriaA); 
            llenarCombo(cmbCategoria);
            /*
            var controles = new[] { updCodigoA, updCodigoE, updCodigoM};

            foreach (var c in controles)
            {
                c.Minimum = 1;
                c.Maximum = 100;
            }*/
            updCodigo.Maximum = 100; //updCodigoE.Maximum = 100; updCodigoE.Minimum = 1;

            updStock.Maximum = 1000; updPrecio.Maximum = 10000;
            dgvProductos.ReadOnly = true;

            conexion.cargarLista(lstProductos);  // Con Access -----> conn.cargarLista(lstProductos);
            conexion.obtenerDatos(dgvProductos); // Con Access -----> conn.obtenerDatos(dgvProductos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (updCodigo.Value != 0)
            {
                if (camposVacios(txtNombre, txtDescripcion, cmbCategoria) != true) //Verificamos que no hayan campos vacios
                {
                    int cod = Convert.ToInt32(updCodigo.Value); int stock = Convert.ToInt32(updStock.Value);
                    string nom = txtNombre.Text; string desc = txtDescripcion.Text;
                    double precio = Convert.ToDouble(updPrecio.Value);
                    string cat = cmbCategoria.Text;

                    if (codRepetido(cod) != true) //Verificamos que el codigo no exista en la base de datos/lista
                    {
                        if (precio > 0) //Verificamos que el producto no sea gratis viste
                        {
                            clsProducto nuevo = new clsProducto(cod, nom, desc, precio, stock, cat);

                            conexion.agregarProducto(nuevo); //Con Access-----> conn.agregarProducto(nuevo);
                            lstProductos.agregarProducto(nuevo); conexion.obtenerDatos(dgvProductos);

                            restablecerValores();
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
            if (camposVacios(txtNombre, txtDescripcion, cmbCategoria) != true)
            {
                //Verificamos que el producto exista mediante el codigo ingresado
                int cod = Convert.ToInt32(updCodigo.Value);
                bool existe = false;
                lstProductos.lstProductos.ForEach(elem =>
                {
                    if (cod == elem.codigo) existe = true;
                });
                //Si el producto existe o no, se procede con los siguientes controles
                if (existe != false)
                {
                    int stock = Convert.ToInt32(updStock.Value);
                    string nom = txtNombre.Text; string desc = txtDescripcion.Text;
                    double precio = Convert.ToDouble(updPrecio.Value);
                    string cat = cmbCategoria.Text;

                    if (precio > 0)
                    {
                        //Conseguimos el producto existente para poder aplicar las nuevas modificaciones
                        clsProducto aux = lstProductos.lstProductos.Find(elem => elem.codigo.Equals(cod));

                        aux.nombre = nom; aux.descripcion = desc; aux.precio = precio;
                        aux.stock = stock; aux.categoria = cat;

                        conexion.actualizarProducto(aux); //Con Access ---> conn.actualizarProducto(aux);
                        lstProductos.lstProductos.Clear();
                        conexion.obtenerDatos(dgvProductos); conexion.cargarLista(lstProductos);

                        restablecerValores();
                        MessageBox.Show("El producto fue modificado con exito.", "🔄 MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("El precio del producto debe valer más de 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("El producto que intenta modiicar no se encuentra en la Base de Datos (El codigo no existe).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codEliminar = Convert.ToInt32(updCodigo.Value);
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

                    updCodigo.Value = 1;
                    MessageBox.Show($"El producto ({nomProducto}) fue eliminado con exito.", "❌ ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("El producto que intenta eliminar NO existe en la Base de Datos (Codigo no encontrado).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            restablecerValores();
            habilitarBotones();
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

        public void restablecerValores()
        {
            updCodigo.Minimum = 0; updCodigo.Value = 0;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            updPrecio.Value = 0;
            updStock.Value = 0;
            cmbCategoria.SelectedIndex = -1;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificar que el botón seleccionado sea el de modificar
            if (optModificar.Checked)
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

                        updCodigo.Value = Convert.ToDecimal(vecDatos[0]); txtNombre.Text = vecDatos[1];
                        txtDescripcion.Text = vecDatos[2]; updPrecio.Value = Convert.ToDecimal(vecDatos[3]);
                        updStock.Value = Convert.ToDecimal(vecDatos[4]);

                        int indice = cmbCategoria.FindStringExact(vecDatos[5]); //<--- Devuelve el indice según el string dado por parametro.
                        cmbCategoria.SelectedIndex = indice;
                    }
                    else
                    {
                        MessageBox.Show("Debe clickear en alguna de las filas donde se encuentra un producto para modificar.", "ERROR AL OBTENER DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        restablecerValores();
                    }
                }
                else
                {
                    MessageBox.Show("Debe clickear en alguna de las filas donde se encuentra un producto para modificar.", "ERROR AL OBTENER DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void habilitarBotones()
        {
            if (updCodigo.Value != 0 && txtNombre.Text != "" && txtDescripcion.Text != "" && updPrecio.Value != 0 &&
                updStock.Value != 0 && cmbCategoria.SelectedIndex != -1)
            {
                if (optAgregar.Checked)
                {
                    btnAgregar.Enabled = true; btnAgregar.BackColor = Color.MediumSpringGreen;
                }
                else if (optModificar.Checked)
                {
                    btnModificar.Enabled = true; btnModificar.BackColor = Color.Turquoise;
                }
            }
            else
            {
                btnAgregar.Enabled = false; btnAgregar.BackColor = Color.Empty;
                btnModificar.Enabled = false; btnModificar.BackColor = Color.Empty;

                if (optEliminar.Checked) //Al elegir la opción de eliminar, el campo de codigo se quedará minimamente con el valor 1.
                {
                    btnEliminar.Enabled = true;
                    btnEliminar.BackColor = Color.IndianRed;
                }
                else
                {
                    btnEliminar.Enabled = false;
                    btnEliminar.BackColor = Color.Empty;
                }
            }
        }

        private void updCodigoM_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void txtNombreM_TextChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void txtDescripcionM_TextChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void updPrecioM_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void updStockM_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void cmbCategoriaM_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void optEliminar_CheckedChanged(object sender, EventArgs e)
        {
            lblAviso.Text = ">>  Para eliminar un producto, por favor ingresar solo  <<\r\nel codigo del producto a eliminar";
            mrcIngresarDatos.BackColor = Color.IndianRed;
            restablecerValores();
            updCodigo.Minimum = 1; habilitarBotones();
            updCodigo.Enabled = true; //Solo se podra "elegir" el codigo para eliminar un producto.
            txtNombre.Enabled = false; txtDescripcion.Enabled = false; cmbCategoria.Enabled = false;
            updPrecio.Enabled = false; updStock.Enabled = false;
        }

        private void optModificar_CheckedChanged(object sender, EventArgs e)
        {
            lblAviso.Text = ">> Para modificar un producto, por favor elija una fila <<\r\nen la grilla que se encuentra debajo";
            mrcIngresarDatos.BackColor = Color.Turquoise;
            restablecerValores(); habilitarBotones();
            updCodigo.Enabled = false; //Se podra modificar todos los campos menos el codigo del producto.
            txtNombre.Enabled = true; txtDescripcion.Enabled = true; cmbCategoria.Enabled = true;
            updPrecio.Enabled = true; updStock.Enabled = true;
        }

        private void optAgregar_CheckedChanged(object sender, EventArgs e)
        {
            lblAviso.Text = ">>  Para agregar un producto, completar los campos  <<\r\nNo puede repetir un mismo codigo";
            mrcIngresarDatos.BackColor = Color.MediumSpringGreen;
            restablecerValores(); habilitarBotones();
            updCodigo.Enabled = true; //Se podra completar todos los campos para agregar un producto. Se habilita todo.
            txtNombre.Enabled = true; txtDescripcion.Enabled = true; cmbCategoria.Enabled = true;
            updPrecio.Enabled = true; updStock.Enabled = true;
        }
    }
}
