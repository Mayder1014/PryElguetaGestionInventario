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

        clsConexionBD conn = new clsConexionBD();
        clsProductos lstProductos = new clsProductos();

        private void frmInicio_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbCategoriaA); llenarCombo(cmbCategoriaM);
            var controles = new[] { updCodigoA, updCodigoM, updCodigoE };

            foreach (var c in controles)
            {
                c.Minimum = 1;
                c.Maximum = 100;
            }

            updStockA.Minimum = 1; updStockA.Maximum = 1000;
            updStockM.Maximum = 1000;

            conn.cargarLista(lstProductos);
            conn.obtenerDatos(dgvProductos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

                        conn.agregarProducto(nuevo); lstProductos.agregarProducto(nuevo);
                        conn.obtenerDatos(dgvProductos);

                        restablecerValores(updCodigoA, txtNombreA, txtDescripcionA, updPrecioA, updStockA, cmbCategoriaA);
                        MessageBox.Show("El producto fue añadido con exito.", "CARGA EXITOSA");
                    }
                    else MessageBox.Show("El precio del producto debe valer más de 0.", "ERROR");
                }
            }
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

                        conn.actualizarProducto(aux); lstProductos.lstProductos.Clear();
                        conn.obtenerDatos(dgvProductos); conn.cargarLista(lstProductos);

                        restablecerValores(updCodigoM, txtNombreM, txtDescripcionM, updPrecioM, updStockM, cmbCategoriaM);
                        MessageBox.Show("El producto fue modificado con exito.", "MODIFICACIÓN EXITOSA");
                    }
                    else MessageBox.Show("El precio del producto debe valer más de 0.","ERROR");
                }
                else MessageBox.Show("El producto que intenta modiicar no se encuentra en la Base de Datos (El codigo no existe).","ERROR");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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

        public bool codRepetido (int cod)
        {
            bool respuesta = false;

            lstProductos.lstProductos.ForEach(elem =>
            {
                if (cod == elem.codigo)
                {
                    respuesta = true;
                    MessageBox.Show("El codigo que intenta ingresar ya fue asignado a otro producto.","ERROR");
                }
            });

            return respuesta;
        }

        public bool camposVacios (TextBox nom, TextBox desc, ComboBox cat)
        {
            bool respuesta = false;

            if (nom.Text == "" || desc.Text == "" || cat.SelectedIndex == -1)
            {
                respuesta = true;
                MessageBox.Show("Hay campos sin completar.","ERROR");
            }

            return respuesta;
        }

        public void restablecerValores(NumericUpDown cod, TextBox nom, TextBox desc, NumericUpDown precio, NumericUpDown stock, ComboBox cat)
        {
            cod.Value = 1;
            nom.Text = "";
            desc.Text = "";
            precio.Value = 0;
            stock.Value = 0;
            cat.SelectedIndex = -1;
        }
    }
}
