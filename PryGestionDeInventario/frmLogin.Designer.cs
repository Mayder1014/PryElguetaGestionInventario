namespace PryGestionDeInventario
{
    partial class frmLogin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblMensajeBienvenida = new System.Windows.Forms.Label();
            this.lblMensajeDeAviso = new System.Windows.Forms.Label();
            this.btnMostrarOcultar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(211, 219);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(263, 216);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.Location = new System.Drawing.Point(288, 329);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 27);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraseña.Location = new System.Drawing.Point(263, 257);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(197, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(193, 260);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblMensajeBienvenida
            // 
            this.lblMensajeBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensajeBienvenida.AutoSize = true;
            this.lblMensajeBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBienvenida.Location = new System.Drawing.Point(129, 126);
            this.lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            this.lblMensajeBienvenida.Size = new System.Drawing.Size(424, 32);
            this.lblMensajeBienvenida.TabIndex = 5;
            this.lblMensajeBienvenida.Text = "¡Bienvenido a la Gestión de Inventario!\r\nPor favor, ingrese los datos que se le s" +
    "olicita a continuación";
            this.lblMensajeBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensajeDeAviso
            // 
            this.lblMensajeDeAviso.AutoSize = true;
            this.lblMensajeDeAviso.Location = new System.Drawing.Point(285, 403);
            this.lblMensajeDeAviso.Name = "lblMensajeDeAviso";
            this.lblMensajeDeAviso.Size = new System.Drawing.Size(91, 13);
            this.lblMensajeDeAviso.TabIndex = 6;
            this.lblMensajeDeAviso.Text = "Mensaje de Aviso";
            this.lblMensajeDeAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajeDeAviso.Visible = false;
            // 
            // btnMostrarOcultar
            // 
            this.btnMostrarOcultar.Location = new System.Drawing.Point(478, 255);
            this.btnMostrarOcultar.Name = "btnMostrarOcultar";
            this.btnMostrarOcultar.Size = new System.Drawing.Size(40, 23);
            this.btnMostrarOcultar.TabIndex = 7;
            this.btnMostrarOcultar.Text = "-";
            this.btnMostrarOcultar.UseVisualStyleBackColor = true;
            this.btnMostrarOcultar.Click += new System.EventHandler(this.btnMostrarOcultar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(567, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Desconectarse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrarOcultar);
            this.Controls.Add(this.lblMensajeDeAviso);
            this.Controls.Add(this.lblMensajeBienvenida);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblMensajeBienvenida;
        private System.Windows.Forms.Label lblMensajeDeAviso;
        private System.Windows.Forms.Button btnMostrarOcultar;
        private System.Windows.Forms.Button button1;
    }
}