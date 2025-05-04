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
            this.lblAvisoDeConexion = new System.Windows.Forms.Label();
            this.lblEstadoUsuario = new System.Windows.Forms.Label();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnVisualizarInventario = new System.Windows.Forms.Button();
            this.btnGestionInventario = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelMenuLateral.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.panelMenuLateral.Controls.Add(this.btnSalir);
            this.panelMenuLateral.Controls.Add(this.btnOpciones);
            this.panelMenuLateral.Controls.Add(this.panelInfo);
            this.panelMenuLateral.Controls.Add(this.panelSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnGestionInventario);
            this.panelMenuLateral.Controls.Add(this.btnLogin);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(237, 746);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Controls.Add(this.linkLabel1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 597);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(237, 149);
            this.panelInfo.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(25, 120);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(172, 16);
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
            this.panelSubMenu.Controls.Add(this.btnVisualizarInventario);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 231);
            this.panelSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(237, 146);
            this.panelSubMenu.TabIndex = 4;
            this.panelSubMenu.Visible = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblEstadoUsuario);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Controls.Add(this.lblAvisoDeConexion);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(237, 159);
            this.panelLogo.TabIndex = 0;
            // 
            // lblAvisoDeConexion
            // 
            this.lblAvisoDeConexion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvisoDeConexion.AutoSize = true;
            this.lblAvisoDeConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoDeConexion.Location = new System.Drawing.Point(11, 9);
            this.lblAvisoDeConexion.Name = "lblAvisoDeConexion";
            this.lblAvisoDeConexion.Size = new System.Drawing.Size(191, 36);
            this.lblAvisoDeConexion.TabIndex = 1;
            this.lblAvisoDeConexion.Text = "Se encuentra conectado\r\ncomo:";
            // 
            // lblEstadoUsuario
            // 
            this.lblEstadoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoUsuario.AutoSize = true;
            this.lblEstadoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoUsuario.Location = new System.Drawing.Point(53, 55);
            this.lblEstadoUsuario.Name = "lblEstadoUsuario";
            this.lblEstadoUsuario.Size = new System.Drawing.Size(154, 20);
            this.lblEstadoUsuario.TabIndex = 0;
            this.lblEstadoUsuario.Text = "Nombre de Usuario";
            this.lblEstadoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFormularios
            // 
            this.panelFormularios.AutoScroll = true;
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.BackgroundImage = global::PryGestionDeInventario.Properties.Resources.logoIES21_removebg_preview;
            this.panelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFormularios.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(237, 0);
            this.panelFormularios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(936, 746);
            this.panelFormularios.TabIndex = 30;
            // 
            // btnOpciones
            // 
            this.btnOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(194)))), ((int)(((byte)(223)))));
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpciones.Image = global::PryGestionDeInventario.Properties.Resources.settings;
            this.btnOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpciones.Location = new System.Drawing.Point(0, 377);
            this.btnOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOpciones.Size = new System.Drawing.Size(237, 36);
            this.btnOpciones.TabIndex = 10;
            this.btnOpciones.Text = "        Opciones";
            this.btnOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpciones.UseVisualStyleBackColor = false;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PryGestionDeInventario.Properties.Resources.iconoGithub;
            this.pictureBox1.Location = new System.Drawing.Point(60, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarProducto.Image = global::PryGestionDeInventario.Properties.Resources.image__1_;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(0, 96);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.btnEliminarProducto.Size = new System.Drawing.Size(237, 32);
            this.btnEliminarProducto.TabIndex = 10;
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
            this.btnModificarProducto.Location = new System.Drawing.Point(0, 64);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.btnModificarProducto.Size = new System.Drawing.Size(237, 32);
            this.btnModificarProducto.TabIndex = 9;
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 32);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.btnAgregarProducto.Size = new System.Drawing.Size(237, 32);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "       Agregar Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnVisualizarInventario
            // 
            this.btnVisualizarInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisualizarInventario.Image = global::PryGestionDeInventario.Properties.Resources.inventory;
            this.btnVisualizarInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarInventario.Location = new System.Drawing.Point(0, 0);
            this.btnVisualizarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisualizarInventario.Name = "btnVisualizarInventario";
            this.btnVisualizarInventario.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.btnVisualizarInventario.Size = new System.Drawing.Size(237, 32);
            this.btnVisualizarInventario.TabIndex = 7;
            this.btnVisualizarInventario.Text = "       Visualizar Inventario";
            this.btnVisualizarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarInventario.UseVisualStyleBackColor = true;
            this.btnVisualizarInventario.Click += new System.EventHandler(this.btnVisualizarInventario_Click);
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
            this.btnGestionInventario.Location = new System.Drawing.Point(0, 195);
            this.btnGestionInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionInventario.Name = "btnGestionInventario";
            this.btnGestionInventario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGestionInventario.Size = new System.Drawing.Size(237, 36);
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
            this.btnLogin.Location = new System.Drawing.Point(0, 159);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(237, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "        Login / Logout";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PryGestionDeInventario.Properties.Resources.activeUser;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(12, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            this.btnSalir.Location = new System.Drawing.Point(0, 413);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(237, 36);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "        Salir del programa";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1173, 746);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelMenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1189, 783);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Gestión De Inventario";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnGestionInventario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVisualizarInventario;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label lblAvisoDeConexion;
        private System.Windows.Forms.Label lblEstadoUsuario;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalir;
    }
}

