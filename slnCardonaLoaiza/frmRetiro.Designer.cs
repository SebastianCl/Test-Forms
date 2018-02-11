namespace slnCardonaLoaiza
{
    partial class frmRetiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetiro));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.gbpBilletes = new System.Windows.Forms.GroupBox();
            this.lblB2 = new System.Windows.Forms.Label();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblB5 = new System.Windows.Forms.Label();
            this.lblB10 = new System.Windows.Forms.Label();
            this.pbB2 = new System.Windows.Forms.PictureBox();
            this.pbB1 = new System.Windows.Forms.PictureBox();
            this.pbB5 = new System.Windows.Forms.PictureBox();
            this.pbB10 = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pbRetirar = new System.Windows.Forms.PictureBox();
            this.gbpBilletes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetirar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a retirar";
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(247, 29);
            this.txtCant.MaxLength = 10;
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(199, 44);
            this.txtCant.TabIndex = 1;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // gbpBilletes
            // 
            this.gbpBilletes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbpBilletes.Controls.Add(this.lblB2);
            this.gbpBilletes.Controls.Add(this.lblB1);
            this.gbpBilletes.Controls.Add(this.lblB5);
            this.gbpBilletes.Controls.Add(this.lblB10);
            this.gbpBilletes.Controls.Add(this.pbB2);
            this.gbpBilletes.Controls.Add(this.pbB1);
            this.gbpBilletes.Controls.Add(this.pbB5);
            this.gbpBilletes.Controls.Add(this.pbB10);
            this.gbpBilletes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbpBilletes.Location = new System.Drawing.Point(12, 98);
            this.gbpBilletes.Name = "gbpBilletes";
            this.gbpBilletes.Size = new System.Drawing.Size(645, 305);
            this.gbpBilletes.TabIndex = 14;
            this.gbpBilletes.TabStop = false;
            this.gbpBilletes.Visible = false;
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB2.Location = new System.Drawing.Point(32, 276);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(17, 20);
            this.lblB2.TabIndex = 21;
            this.lblB2.Text = "x";
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB1.Location = new System.Drawing.Point(367, 276);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(17, 20);
            this.lblB1.TabIndex = 20;
            this.lblB1.Text = "x";
            // 
            // lblB5
            // 
            this.lblB5.AutoSize = true;
            this.lblB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB5.Location = new System.Drawing.Point(367, 115);
            this.lblB5.Name = "lblB5";
            this.lblB5.Size = new System.Drawing.Size(17, 20);
            this.lblB5.TabIndex = 19;
            this.lblB5.Text = "x";
            // 
            // lblB10
            // 
            this.lblB10.AutoSize = true;
            this.lblB10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB10.Location = new System.Drawing.Point(32, 115);
            this.lblB10.Name = "lblB10";
            this.lblB10.Size = new System.Drawing.Size(17, 20);
            this.lblB10.TabIndex = 18;
            this.lblB10.Text = "x";
            // 
            // pbB2
            // 
            this.pbB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbB2.Image = ((System.Drawing.Image)(resources.GetObject("pbB2.Image")));
            this.pbB2.Location = new System.Drawing.Point(25, 180);
            this.pbB2.Name = "pbB2";
            this.pbB2.Size = new System.Drawing.Size(253, 93);
            this.pbB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbB2.TabIndex = 17;
            this.pbB2.TabStop = false;
            // 
            // pbB1
            // 
            this.pbB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbB1.Image = ((System.Drawing.Image)(resources.GetObject("pbB1.Image")));
            this.pbB1.Location = new System.Drawing.Point(361, 180);
            this.pbB1.Name = "pbB1";
            this.pbB1.Size = new System.Drawing.Size(244, 95);
            this.pbB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbB1.TabIndex = 16;
            this.pbB1.TabStop = false;
            // 
            // pbB5
            // 
            this.pbB5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbB5.Image = ((System.Drawing.Image)(resources.GetObject("pbB5.Image")));
            this.pbB5.Location = new System.Drawing.Point(361, 19);
            this.pbB5.Name = "pbB5";
            this.pbB5.Size = new System.Drawing.Size(247, 92);
            this.pbB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbB5.TabIndex = 15;
            this.pbB5.TabStop = false;
            // 
            // pbB10
            // 
            this.pbB10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbB10.Image = ((System.Drawing.Image)(resources.GetObject("pbB10.Image")));
            this.pbB10.Location = new System.Drawing.Point(25, 19);
            this.pbB10.Name = "pbB10";
            this.pbB10.Size = new System.Drawing.Size(250, 93);
            this.pbB10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbB10.TabIndex = 14;
            this.pbB10.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(737, 362);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(145, 47);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "NUEVO RETIRO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.bntNuevo_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMensaje.Location = new System.Drawing.Point(500, 38);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(60, 25);
            this.lblMensaje.TabIndex = 16;
            this.lblMensaje.Text = "------";
            // 
            // pbRetirar
            // 
            this.pbRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRetirar.Image = ((System.Drawing.Image)(resources.GetObject("pbRetirar.Image")));
            this.pbRetirar.Location = new System.Drawing.Point(702, 117);
            this.pbRetirar.Name = "pbRetirar";
            this.pbRetirar.Size = new System.Drawing.Size(223, 213);
            this.pbRetirar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRetirar.TabIndex = 17;
            this.pbRetirar.TabStop = false;
            this.pbRetirar.Click += new System.EventHandler(this.pbRetirar_Click);
            // 
            // frmRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 419);
            this.Controls.Add(this.pbRetirar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbpBilletes);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRetiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiro Agil";
            this.Load += new System.EventHandler(this.frmRetiro_Load);
            this.gbpBilletes.ResumeLayout(false);
            this.gbpBilletes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetirar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblB2;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblB5;
        private System.Windows.Forms.Label lblB10;
        private System.Windows.Forms.PictureBox pbB2;
        private System.Windows.Forms.PictureBox pbB1;
        private System.Windows.Forms.PictureBox pbB5;
        private System.Windows.Forms.PictureBox pbB10;
        private System.Windows.Forms.GroupBox gbpBilletes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pbRetirar;
    }
}