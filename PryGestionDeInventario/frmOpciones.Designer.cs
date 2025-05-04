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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 690);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optModoVentana;
        private System.Windows.Forms.RadioButton optPantallaCompleta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optTemaClaro;
        private System.Windows.Forms.RadioButton optTemaOscuro;
        private System.Windows.Forms.Button btnVolver;
    }
}