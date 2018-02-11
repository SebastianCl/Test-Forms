namespace slnCardonaLoaiza
{
    partial class frmFacturador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturador));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpDatos = new System.Windows.Forms.GroupBox();
            this.pbRegistrar = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.nupCodigo = new System.Windows.Forms.NumericUpDown();
            this.gpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(11, 109);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(99, 13);
            this.lblConfirmacion.TabIndex = 5;
            this.lblConfirmacion.Text = "Producto registrado";
            this.lblConfirmacion.Visible = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Enabled = false;
            this.btnFacturar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(12, 173);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(467, 40);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Mostrar factura";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // txtFactura
            // 
            this.txtFactura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(12, 219);
            this.txtFactura.Multiline = true;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(328, 234);
            this.txtFactura.TabIndex = 7;
            this.txtFactura.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(361, 219);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 234);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpDatos
            // 
            this.gpDatos.Controls.Add(this.pbRegistrar);
            this.gpDatos.Controls.Add(this.txtCantidad);
            this.gpDatos.Controls.Add(this.nupCodigo);
            this.gpDatos.Controls.Add(this.label1);
            this.gpDatos.Controls.Add(this.label2);
            this.gpDatos.Controls.Add(this.lblConfirmacion);
            this.gpDatos.Location = new System.Drawing.Point(12, 12);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Size = new System.Drawing.Size(467, 141);
            this.gpDatos.TabIndex = 9;
            this.gpDatos.TabStop = false;
            // 
            // pbRegistrar
            // 
            this.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("pbRegistrar.Image")));
            this.pbRegistrar.Location = new System.Drawing.Point(321, 7);
            this.pbRegistrar.Name = "pbRegistrar";
            this.pbRegistrar.Size = new System.Drawing.Size(128, 128);
            this.pbRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRegistrar.TabIndex = 9;
            this.pbRegistrar.TabStop = false;
            this.pbRegistrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRegistrar_MouseClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(117, 60);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 35);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress_1);
            // 
            // nupCodigo
            // 
            this.nupCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCodigo.Location = new System.Drawing.Point(117, 19);
            this.nupCodigo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupCodigo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCodigo.Name = "nupCodigo";
            this.nupCodigo.ReadOnly = true;
            this.nupCodigo.Size = new System.Drawing.Size(120, 35);
            this.nupCodigo.TabIndex = 7;
            this.nupCodigo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmFacturador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(491, 464);
            this.Controls.Add(this.gpDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.btnFacturar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFacturador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturador";
            this.Load += new System.EventHandler(this.frmFacturador_Load);
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.NumericUpDown nupCodigo;
        private System.Windows.Forms.PictureBox pbRegistrar;
    }
}