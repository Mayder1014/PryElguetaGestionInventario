namespace PryGestionDeInventario
{
    partial class frmEliminarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.mrcIngresarDatos = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.updCodigo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.updPrecio = new System.Windows.Forms.NumericUpDown();
            this.updStock = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcIngresarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.LightGray;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(525, 213);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(78, 213);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(50, 23);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // mrcIngresarDatos
            // 
            this.mrcIngresarDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mrcIngresarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.mrcIngresarDatos.Controls.Add(this.lblAviso);
            this.mrcIngresarDatos.Controls.Add(this.label8);
            this.mrcIngresarDatos.Controls.Add(this.cmbCategoria);
            this.mrcIngresarDatos.Controls.Add(this.label13);
            this.mrcIngresarDatos.Controls.Add(this.txtNombre);
            this.mrcIngresarDatos.Controls.Add(this.label12);
            this.mrcIngresarDatos.Controls.Add(this.label11);
            this.mrcIngresarDatos.Controls.Add(this.updCodigo);
            this.mrcIngresarDatos.Controls.Add(this.label10);
            this.mrcIngresarDatos.Controls.Add(this.label9);
            this.mrcIngresarDatos.Controls.Add(this.updPrecio);
            this.mrcIngresarDatos.Controls.Add(this.updStock);
            this.mrcIngresarDatos.Controls.Add(this.txtDescripcion);
            this.mrcIngresarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresarDatos.Location = new System.Drawing.Point(78, 11);
            this.mrcIngresarDatos.Name = "mrcIngresarDatos";
            this.mrcIngresarDatos.Size = new System.Drawing.Size(522, 196);
            this.mrcIngresarDatos.TabIndex = 38;
            this.mrcIngresarDatos.TabStop = false;
            this.mrcIngresarDatos.Text = "Ingresar datos...";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Lavender;
            this.lblAviso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(48, 30);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(406, 28);
            this.lblAviso.TabIndex = 13;
            this.lblAviso.Text = ">>  Para eliminar un producto, por favor ingresar solo el código del <<\r\nproducto" +
    " a eliminar, o seleccione una fila de la grilla debajo";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Código:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(333, 111);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(136, 21);
            this.cmbCategoria.TabIndex = 4;
            this.cmbCategoria.Text = "Seleccionar categoría...";
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            this.cmbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoria_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(346, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Stock:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(92, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 19);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(182, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(279, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Categoría:";
            // 
            // updCodigo
            // 
            this.updCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updCodigo.Location = new System.Drawing.Point(92, 74);
            this.updCodigo.Name = "updCodigo";
            this.updCodigo.Size = new System.Drawing.Size(56, 19);
            this.updCodigo.TabIndex = 0;
            this.updCodigo.ValueChanged += new System.EventHandler(this.updCodigo_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nombre:";
            // 
            // updPrecio
            // 
            this.updPrecio.Enabled = false;
            this.updPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updPrecio.Location = new System.Drawing.Point(226, 73);
            this.updPrecio.Name = "updPrecio";
            this.updPrecio.Size = new System.Drawing.Size(80, 19);
            this.updPrecio.TabIndex = 1;
            this.updPrecio.ValueChanged += new System.EventHandler(this.updPrecio_ValueChanged);
            // 
            // updStock
            // 
            this.updStock.Enabled = false;
            this.updStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updStock.Location = new System.Drawing.Point(385, 73);
            this.updStock.Name = "updStock";
            this.updStock.Size = new System.Drawing.Size(83, 19);
            this.updStock.TabIndex = 2;
            this.updStock.ValueChanged += new System.EventHandler(this.updStock_ValueChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(92, 146);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(377, 33);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(10, 248);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(668, 303);
            this.dgvProductos.TabIndex = 37;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(10, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(50, 23);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 561);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.mrcIngresarDatos);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnEliminar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEliminarProducto";
            this.Text = "frmEliminarProducto";
            this.Load += new System.EventHandler(this.frmEliminarProducto_Load);
            this.mrcIngresarDatos.ResumeLayout(false);
            this.mrcIngresarDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox mrcIngresarDatos;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown updCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown updPrecio;
        private System.Windows.Forms.NumericUpDown updStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnVolver;
    }
}