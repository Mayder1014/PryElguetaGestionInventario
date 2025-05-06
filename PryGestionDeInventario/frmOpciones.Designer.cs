namespace PryGestionDeInventario
{
    partial class frmOpciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optModoVentana = new System.Windows.Forms.RadioButton();
            this.optPantallaCompleta = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optTemaClaro = new System.Windows.Forms.RadioButton();
            this.optTemaOscuro = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcDesbloquearUsuarios = new System.Windows.Forms.GroupBox();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.cmbUsuariosBloqueados = new System.Windows.Forms.ComboBox();
            this.lblInstruccionAdmin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mrcDesbloquearUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.optModoVentana);
            this.groupBox1.Controls.Add(this.optPantallaCompleta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 83);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de pantalla";
            // 
            // optModoVentana
            // 
            this.optModoVentana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optModoVentana.AutoSize = true;
            this.optModoVentana.Checked = true;
            this.optModoVentana.Location = new System.Drawing.Point(101, 34);
            this.optModoVentana.Name = "optModoVentana";
            this.optModoVentana.Size = new System.Drawing.Size(137, 24);
            this.optModoVentana.TabIndex = 1;
            this.optModoVentana.TabStop = true;
            this.optModoVentana.Text = "Modo Ventana";
            this.optModoVentana.UseVisualStyleBackColor = true;
            this.optModoVentana.CheckedChanged += new System.EventHandler(this.optModoVentana_CheckedChanged);
            // 
            // optPantallaCompleta
            // 
            this.optPantallaCompleta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optPantallaCompleta.AutoSize = true;
            this.optPantallaCompleta.Location = new System.Drawing.Point(410, 34);
            this.optPantallaCompleta.Name = "optPantallaCompleta";
            this.optPantallaCompleta.Size = new System.Drawing.Size(166, 24);
            this.optPantallaCompleta.TabIndex = 0;
            this.optPantallaCompleta.Text = "Pantalla Completa";
            this.optPantallaCompleta.UseVisualStyleBackColor = true;
            this.optPantallaCompleta.CheckedChanged += new System.EventHandler(this.optPantallaCompleta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.optTemaClaro);
            this.groupBox2.Controls.Add(this.optTemaOscuro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(108, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 83);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tema";
            // 
            // optTemaClaro
            // 
            this.optTemaClaro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optTemaClaro.AutoSize = true;
            this.optTemaClaro.Checked = true;
            this.optTemaClaro.Location = new System.Drawing.Point(135, 34);
            this.optTemaClaro.Name = "optTemaClaro";
            this.optTemaClaro.Size = new System.Drawing.Size(70, 24);
            this.optTemaClaro.TabIndex = 1;
            this.optTemaClaro.TabStop = true;
            this.optTemaClaro.Text = "Claro";
            this.optTemaClaro.UseVisualStyleBackColor = true;
            this.optTemaClaro.CheckedChanged += new System.EventHandler(this.optTemaClaro_CheckedChanged);
            // 
            // optTemaOscuro
            // 
            this.optTemaOscuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optTemaOscuro.AutoSize = true;
            this.optTemaOscuro.Location = new System.Drawing.Point(453, 34);
            this.optTemaOscuro.Name = "optTemaOscuro";
            this.optTemaOscuro.Size = new System.Drawing.Size(85, 24);
            this.optTemaOscuro.TabIndex = 0;
            this.optTemaOscuro.Text = "Oscuro";
            this.optTemaOscuro.UseVisualStyleBackColor = true;
            this.optTemaOscuro.CheckedChanged += new System.EventHandler(this.optTemaOscuro_CheckedChanged);
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
            // mrcDesbloquearUsuarios
            // 
            this.mrcDesbloquearUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mrcDesbloquearUsuarios.BackColor = System.Drawing.Color.IndianRed;
            this.mrcDesbloquearUsuarios.Controls.Add(this.btnDesbloquear);
            this.mrcDesbloquearUsuarios.Controls.Add(this.cmbUsuariosBloqueados);
            this.mrcDesbloquearUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDesbloquearUsuarios.Location = new System.Drawing.Point(108, 361);
            this.mrcDesbloquearUsuarios.Name = "mrcDesbloquearUsuarios";
            this.mrcDesbloquearUsuarios.Size = new System.Drawing.Size(675, 83);
            this.mrcDesbloquearUsuarios.TabIndex = 44;
            this.mrcDesbloquearUsuarios.TabStop = false;
            this.mrcDesbloquearUsuarios.Text = "Desbloquear Usuarios";
            this.mrcDesbloquearUsuarios.Visible = false;
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesbloquear.BackColor = System.Drawing.Color.Red;
            this.btnDesbloquear.Enabled = false;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.Location = new System.Drawing.Point(489, 36);
            this.btnDesbloquear.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(169, 33);
            this.btnDesbloquear.TabIndex = 3;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = false;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // cmbUsuariosBloqueados
            // 
            this.cmbUsuariosBloqueados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsuariosBloqueados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuariosBloqueados.FormattingEnabled = true;
            this.cmbUsuariosBloqueados.Location = new System.Drawing.Point(16, 38);
            this.cmbUsuariosBloqueados.Name = "cmbUsuariosBloqueados";
            this.cmbUsuariosBloqueados.Size = new System.Drawing.Size(453, 28);
            this.cmbUsuariosBloqueados.TabIndex = 0;
            this.cmbUsuariosBloqueados.SelectedIndexChanged += new System.EventHandler(this.cmbUsuariosBloqueados_SelectedIndexChanged);
            // 
            // lblInstruccionAdmin
            // 
            this.lblInstruccionAdmin.AutoSize = true;
            this.lblInstruccionAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccionAdmin.Location = new System.Drawing.Point(105, 307);
            this.lblInstruccionAdmin.Name = "lblInstruccionAdmin";
            this.lblInstruccionAdmin.Size = new System.Drawing.Size(589, 40);
            this.lblInstruccionAdmin.TabIndex = 45;
            this.lblInstruccionAdmin.Text = "* A continuación puede ver los usuarios que fueron bloqueados.\r\n  Si desea desblo" +
    "quear alguno, seleccionelo y haga click en el botón.";
            this.lblInstruccionAdmin.Visible = false;
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 690);
            this.Controls.Add(this.lblInstruccionAdmin);
            this.Controls.Add(this.mrcDesbloquearUsuarios);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOpciones";
            this.Text = "frmOpciones";
            this.Load += new System.EventHandler(this.frmOpciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mrcDesbloquearUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optModoVentana;
        private System.Windows.Forms.RadioButton optPantallaCompleta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optTemaClaro;
        private System.Windows.Forms.RadioButton optTemaOscuro;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox mrcDesbloquearUsuarios;
        private System.Windows.Forms.ComboBox cmbUsuariosBloqueados;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Label lblInstruccionAdmin;
    }
}