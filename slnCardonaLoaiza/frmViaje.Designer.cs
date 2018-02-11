namespace slnCardonaLoaiza
{
    partial class frmViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViaje));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dtpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSuite = new System.Windows.Forms.RadioButton();
            this.txtNumDias = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBarco = new System.Windows.Forms.GroupBox();
            this.cmbCamarote = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiasBarco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbAvion = new System.Windows.Forms.GroupBox();
            this.txtCantidadMillas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorMillas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTasaAero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pbAvion = new System.Windows.Forms.PictureBox();
            this.pbBarco = new System.Windows.Forms.PictureBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.gbBarco.SuspendLayout();
            this.gbAvion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarco)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.dtpFechaViaje);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtTransporte);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.rbNormal);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.rbSuite);
            this.gbDatos.Controls.Add(this.txtNumDias);
            this.gbDatos.Controls.Add(this.txtDestino);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtCedula);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(54, 121);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(510, 161);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.Location = new System.Drawing.Point(293, 128);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaViaje.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha de viaje:  ";
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(299, 97);
            this.txtTransporte.MaxLength = 10;
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtTransporte.TabIndex = 10;
            this.txtTransporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransporte_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Transporte: ";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(109, 127);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 4;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo de habitación: ";
            // 
            // rbSuite
            // 
            this.rbSuite.AutoSize = true;
            this.rbSuite.Location = new System.Drawing.Point(109, 106);
            this.rbSuite.Name = "rbSuite";
            this.rbSuite.Size = new System.Drawing.Size(49, 17);
            this.rbSuite.TabIndex = 3;
            this.rbSuite.TabStop = true;
            this.rbSuite.Text = "Suite";
            this.rbSuite.UseVisualStyleBackColor = true;
            // 
            // txtNumDias
            // 
            this.txtNumDias.Location = new System.Drawing.Point(299, 64);
            this.txtNumDias.MaxLength = 9;
            this.txtNumDias.Name = "txtNumDias";
            this.txtNumDias.Size = new System.Drawing.Size(100, 20);
            this.txtNumDias.TabIndex = 7;
            this.txtNumDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDias_KeyPress);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(71, 57);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 5;
            this.txtDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestino_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número de días:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destino:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(299, 29);
            this.txtCedula.MaxLength = 30;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // gbBarco
            // 
            this.gbBarco.Controls.Add(this.cmbCamarote);
            this.gbBarco.Controls.Add(this.label10);
            this.gbBarco.Controls.Add(this.txtDiasBarco);
            this.gbBarco.Controls.Add(this.label8);
            this.gbBarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBarco.Location = new System.Drawing.Point(11, 288);
            this.gbBarco.Name = "gbBarco";
            this.gbBarco.Size = new System.Drawing.Size(293, 89);
            this.gbBarco.TabIndex = 3;
            this.gbBarco.TabStop = false;
            this.gbBarco.Text = "Barco";
            this.gbBarco.Visible = false;
            // 
            // cmbCamarote
            // 
            this.cmbCamarote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamarote.Location = new System.Drawing.Point(152, 52);
            this.cmbCamarote.Name = "cmbCamarote";
            this.cmbCamarote.Size = new System.Drawing.Size(121, 28);
            this.cmbCamarote.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tipo de camarote:";
            // 
            // txtDiasBarco
            // 
            this.txtDiasBarco.Location = new System.Drawing.Point(153, 16);
            this.txtDiasBarco.MaxLength = 9;
            this.txtDiasBarco.Name = "txtDiasBarco";
            this.txtDiasBarco.Size = new System.Drawing.Size(120, 26);
            this.txtDiasBarco.TabIndex = 9;
            this.txtDiasBarco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasBarco_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Número de días:";
            // 
            // gbAvion
            // 
            this.gbAvion.Controls.Add(this.txtCantidadMillas);
            this.gbAvion.Controls.Add(this.label12);
            this.gbAvion.Controls.Add(this.txtValorMillas);
            this.gbAvion.Controls.Add(this.label11);
            this.gbAvion.Controls.Add(this.txtTasaAero);
            this.gbAvion.Controls.Add(this.label9);
            this.gbAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvion.Location = new System.Drawing.Point(310, 288);
            this.gbAvion.Name = "gbAvion";
            this.gbAvion.Size = new System.Drawing.Size(286, 123);
            this.gbAvion.TabIndex = 10;
            this.gbAvion.TabStop = false;
            this.gbAvion.Text = "Avión";
            this.gbAvion.Visible = false;
            // 
            // txtCantidadMillas
            // 
            this.txtCantidadMillas.Location = new System.Drawing.Point(169, 83);
            this.txtCantidadMillas.MaxLength = 9;
            this.txtCantidadMillas.Name = "txtCantidadMillas";
            this.txtCantidadMillas.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadMillas.TabIndex = 13;
            this.txtCantidadMillas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cantidad:";
            // 
            // txtValorMillas
            // 
            this.txtValorMillas.Location = new System.Drawing.Point(169, 51);
            this.txtValorMillas.MaxLength = 10;
            this.txtValorMillas.Name = "txtValorMillas";
            this.txtValorMillas.Size = new System.Drawing.Size(100, 26);
            this.txtValorMillas.TabIndex = 11;
            this.txtValorMillas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMillas_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valor millas:";
            // 
            // txtTasaAero
            // 
            this.txtTasaAero.Location = new System.Drawing.Point(169, 19);
            this.txtTasaAero.MaxLength = 10;
            this.txtTasaAero.Name = "txtTasaAero";
            this.txtTasaAero.Size = new System.Drawing.Size(100, 26);
            this.txtTasaAero.TabIndex = 9;
            this.txtTasaAero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaAero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tasa Aeroportuaria: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(437, 467);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(159, 27);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Nueva Consulta";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(437, 417);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(159, 41);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 413);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(25, 13);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "------";
            this.lblMensaje.Visible = false;
            // 
            // pbAvion
            // 
            this.pbAvion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvion.Image = ((System.Drawing.Image)(resources.GetObject("pbAvion.Image")));
            this.pbAvion.Location = new System.Drawing.Point(385, 12);
            this.pbAvion.Name = "pbAvion";
            this.pbAvion.Size = new System.Drawing.Size(100, 85);
            this.pbAvion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvion.TabIndex = 16;
            this.pbAvion.TabStop = false;
            this.pbAvion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAvion_MouseClick);
            // 
            // pbBarco
            // 
            this.pbBarco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBarco.Image = ((System.Drawing.Image)(resources.GetObject("pbBarco.Image")));
            this.pbBarco.Location = new System.Drawing.Point(144, 12);
            this.pbBarco.Name = "pbBarco";
            this.pbBarco.Size = new System.Drawing.Size(100, 85);
            this.pbBarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarco.TabIndex = 17;
            this.pbBarco.TabStop = false;
            this.pbBarco.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbBarco_MouseClick);
            // 
            // lblSalida
            // 
            this.lblSalida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.Black;
            this.lblSalida.Location = new System.Drawing.Point(15, 426);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(416, 59);
            this.lblSalida.TabIndex = 18;
            this.lblSalida.Visible = false;
            // 
            // frmViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(623, 505);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.pbBarco);
            this.Controls.Add(this.pbAvion);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gbAvion);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbBarco);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 270);
            this.Name = "frmViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viaje";
            this.Load += new System.EventHandler(this.frmViaje_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbBarco.ResumeLayout(false);
            this.gbBarco.PerformLayout();
            this.gbAvion.ResumeLayout(false);
            this.gbAvion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSuite;
        private System.Windows.Forms.TextBox txtNumDias;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBarco;
        private System.Windows.Forms.TextBox txtDiasBarco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCamarote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbAvion;
        private System.Windows.Forms.TextBox txtValorMillas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTasaAero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pbAvion;
        private System.Windows.Forms.PictureBox pbBarco;
        private System.Windows.Forms.DateTimePicker dtpFechaViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtCantidadMillas;
        private System.Windows.Forms.Label label12;
    }
}