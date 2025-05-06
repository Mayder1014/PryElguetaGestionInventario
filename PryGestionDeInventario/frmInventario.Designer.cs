namespace PryGestionDeInventario
{
    partial class frmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.mrcBuscarFiltrar = new System.Windows.Forms.GroupBox();
            this.optFiltrarCategoria = new System.Windows.Forms.RadioButton();
            this.optBuscarCodigo = new System.Windows.Forms.RadioButton();
            this.cmbIngresar = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.updIngresar = new System.Windows.Forms.NumericUpDown();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.mrcBuscarFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(13, 128);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(891, 549);
            this.dgvProductos.TabIndex = 32;
            // 
            // lblIngresar
            // 
            this.lblIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(321, 47);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(59, 16);
            this.lblIngresar.TabIndex = 34;
            this.lblIngresar.Text = "Ingresar:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(386, 83);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(139, 29);
            this.btnFiltrar.TabIndex = 35;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // mrcBuscarFiltrar
            // 
            this.mrcBuscarFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mrcBuscarFiltrar.Controls.Add(this.optFiltrarCategoria);
            this.mrcBuscarFiltrar.Controls.Add(this.optBuscarCodigo);
            this.mrcBuscarFiltrar.Location = new System.Drawing.Point(93, 12);
            this.mrcBuscarFiltrar.Name = "mrcBuscarFiltrar";
            this.mrcBuscarFiltrar.Size = new System.Drawing.Size(152, 100);
            this.mrcBuscarFiltrar.TabIndex = 36;
            this.mrcBuscarFiltrar.TabStop = false;
            this.mrcBuscarFiltrar.Text = "Buscar/Filtrar..";
            // 
            // optFiltrarCategoria
            // 
            this.optFiltrarCategoria.AutoSize = true;
            this.optFiltrarCategoria.Location = new System.Drawing.Point(6, 60);
            this.optFiltrarCategoria.Name = "optFiltrarCategoria";
            this.optFiltrarCategoria.Size = new System.Drawing.Size(111, 20);
            this.optFiltrarCategoria.TabIndex = 1;
            this.optFiltrarCategoria.Text = "Por Categoria";
            this.optFiltrarCategoria.UseVisualStyleBackColor = true;
            this.optFiltrarCategoria.CheckedChanged += new System.EventHandler(this.optFiltrarCategoria_CheckedChanged);
            // 
            // optBuscarCodigo
            // 
            this.optBuscarCodigo.AutoSize = true;
            this.optBuscarCodigo.Checked = true;
            this.optBuscarCodigo.Location = new System.Drawing.Point(6, 34);
            this.optBuscarCodigo.Name = "optBuscarCodigo";
            this.optBuscarCodigo.Size = new System.Drawing.Size(96, 20);
            this.optBuscarCodigo.TabIndex = 0;
            this.optBuscarCodigo.TabStop = true;
            this.optBuscarCodigo.Text = "Por Codigo";
            this.optBuscarCodigo.UseVisualStyleBackColor = true;
            this.optBuscarCodigo.CheckedChanged += new System.EventHandler(this.optBuscarCodigo_CheckedChanged);
            // 
            // cmbIngresar
            // 
            this.cmbIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbIngresar.FormattingEnabled = true;
            this.cmbIngresar.Location = new System.Drawing.Point(386, 46);
            this.cmbIngresar.Name = "cmbIngresar";
            this.cmbIngresar.Size = new System.Drawing.Size(223, 24);
            this.cmbIngresar.TabIndex = 37;
            this.cmbIngresar.Visible = false;
            this.cmbIngresar.SelectedIndexChanged += new System.EventHandler(this.cmbIngresar_SelectedIndexChanged);
            this.cmbIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIngresar_KeyPress);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolver.BackgroundImage = global::PryGestionDeInventario.Properties.Resources.go_back;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(13, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(42, 36);
            this.btnVolver.TabIndex = 43;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // updIngresar
            // 
            this.updIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updIngresar.Location = new System.Drawing.Point(386, 46);
            this.updIngresar.Name = "updIngresar";
            this.updIngresar.Size = new System.Drawing.Size(139, 22);
            this.updIngresar.TabIndex = 44;
            this.updIngresar.ValueChanged += new System.EventHandler(this.updIngresar_ValueChanged);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMostrarTodo.Location = new System.Drawing.Point(698, 47);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(114, 45);
            this.btnMostrarTodo.TabIndex = 45;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 690);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.updIngresar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cmbIngresar);
            this.Controls.Add(this.mrcBuscarFiltrar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.mrcBuscarFiltrar.ResumeLayout(false);
            this.mrcBuscarFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updIngresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox mrcBuscarFiltrar;
        private System.Windows.Forms.RadioButton optFiltrarCategoria;
        private System.Windows.Forms.RadioButton optBuscarCodigo;
        private System.Windows.Forms.ComboBox cmbIngresar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.NumericUpDown updIngresar;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}