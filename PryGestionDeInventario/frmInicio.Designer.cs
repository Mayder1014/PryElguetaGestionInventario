namespace PryGestionDeInventario
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnGestionInventario = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelMenuLateral.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.panelMenuLateral.Controls.Add(this.panelInfo);
            this.panelMenuLateral.Controls.Add(this.btnSalir);
            this.panelMenuLateral.Controls.Add(this.panelSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnGestionInventario);
            this.panelMenuLateral.Controls.Add(this.btnLogin);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(178, 606);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Controls.Add(this.linkLabel1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 485);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(178, 121);
            this.panelInfo.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(28, 99);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github del Programador";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(223)))));
            this.panelSubMenu.Controls.Add(this.btnEliminarProducto);
            this.panelSubMenu.Controls.Add(this.btnModificarProducto);
            this.panelSubMenu.Controls.Add(this.btnAgregarProducto);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 158);
            this.panelSubMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(178, 83);
            this.panelSubMenu.TabIndex = 4;
            this.panelSubMenu.Visible = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(178, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.AutoScroll = true;
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.BackgroundImage = global::PryGestionDeInventario.Properties.Resources.logoIES21_removebg_preview;
            this.panelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFormularios.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(178, 0);
            this.panelFormularios.Margin = new System.Windows.Forms.Padding(2);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(702, 606);
            this.panelFormularios.TabIndex = 30;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PryGestionDeInventario.Properties.Resources.iconoGithub;
            this.pictureBox1.Location = new System.Drawing.Point(46, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(223)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Image = global::PryGestionDeInventario.Properties.Resources.logout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 241);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(178, 29);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "        Salir del programa";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarProducto.Image = global::PryGestionDeInventario.Properties.Resources.image__1_;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(0, 52);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnEliminarProducto.Size = new System.Drawing.Size(178, 26);
            this.btnEliminarProducto.TabIndex = 6;
            this.btnEliminarProducto.Text = "       Eliminar Producto";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarProducto.Image = global::PryGestionDeInventario.Properties.Resources.writing;
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.Location = new System.Drawing.Point(0, 26);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnModificarProducto.Size = new System.Drawing.Size(178, 26);
            this.btnModificarProducto.TabIndex = 5;
            this.btnModificarProducto.Text = "       Modificar Producto";
            this.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarProducto.Image = global::PryGestionDeInventario.Properties.Resources.add;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnAgregarProducto.Size = new System.Drawing.Size(178, 26);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "       Agregar Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnGestionInventario
            // 
            this.btnGestionInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionInventario.FlatAppearance.BorderSize = 0;
            this.btnGestionInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(223)))));
            this.btnGestionInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGestionInventario.Image = global::PryGestionDeInventario.Properties.Resources.image;
            this.btnGestionInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionInventario.Location = new System.Drawing.Point(0, 129);
            this.btnGestionInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionInventario.Name = "btnGestionInventario";
            this.btnGestionInventario.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnGestionInventario.Size = new System.Drawing.Size(178, 29);
            this.btnGestionInventario.TabIndex = 2;
            this.btnGestionInventario.Text = "        Gestión de Inventario";
            this.btnGestionInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionInventario.UseVisualStyleBackColor = true;
            this.btnGestionInventario.Click += new System.EventHandler(this.btnGestionInventario_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(223)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Image = global::PryGestionDeInventario.Properties.Resources.user__2_;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 100);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(178, 29);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "        Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 606);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelMenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(896, 645);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Gestión De Inventario";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnGestionInventario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

