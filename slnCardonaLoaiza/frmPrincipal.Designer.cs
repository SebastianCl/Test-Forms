namespace slnCardonaLoaiza
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnMenu = new System.Windows.Forms.MenuStrip();
            this.miRetiro = new System.Windows.Forms.ToolStripMenuItem();
            this.miTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.miViaje = new System.Windows.Forms.ToolStripMenuItem();
            this.miHome = new System.Windows.Forms.ToolStripMenuItem();
            this.miSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.miFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAutor = new System.Windows.Forms.Label();
            this.mnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMenu
            // 
            this.mnMenu.BackColor = System.Drawing.Color.White;
            this.mnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRetiro,
            this.miTest,
            this.miFactura,
            this.miViaje,
            this.miHome,
            this.miSalir,
            this.miFecha});
            this.mnMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.Size = new System.Drawing.Size(1354, 136);
            this.mnMenu.TabIndex = 0;
            // 
            // miRetiro
            // 
            this.miRetiro.Image = ((System.Drawing.Image)(resources.GetObject("miRetiro.Image")));
            this.miRetiro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miRetiro.Name = "miRetiro";
            this.miRetiro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.miRetiro.Size = new System.Drawing.Size(218, 132);
            this.miRetiro.Text = "&Retiro Rapido";
            this.miRetiro.Click += new System.EventHandler(this.miRetiro_Click);
            // 
            // miTest
            // 
            this.miTest.Image = ((System.Drawing.Image)(resources.GetObject("miTest.Image")));
            this.miTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miTest.Name = "miTest";
            this.miTest.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.miTest.Size = new System.Drawing.Size(228, 132);
            this.miTest.Text = "&Test de Anemia";
            this.miTest.Click += new System.EventHandler(this.miTest_Click);
            // 
            // miFactura
            // 
            this.miFactura.Image = ((System.Drawing.Image)(resources.GetObject("miFactura.Image")));
            this.miFactura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miFactura.Name = "miFactura";
            this.miFactura.ShortcutKeyDisplayString = "";
            this.miFactura.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.miFactura.Size = new System.Drawing.Size(190, 132);
            this.miFactura.Text = "&Facturar";
            this.miFactura.Click += new System.EventHandler(this.miFactura_Click);
            // 
            // miViaje
            // 
            this.miViaje.Image = ((System.Drawing.Image)(resources.GetObject("miViaje.Image")));
            this.miViaje.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miViaje.Name = "miViaje";
            this.miViaje.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.miViaje.Size = new System.Drawing.Size(172, 132);
            this.miViaje.Text = "V&iaje";
            this.miViaje.Click += new System.EventHandler(this.miViaje_Click);
            // 
            // miHome
            // 
            this.miHome.Image = ((System.Drawing.Image)(resources.GetObject("miHome.Image")));
            this.miHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miHome.Name = "miHome";
            this.miHome.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.miHome.Size = new System.Drawing.Size(122, 132);
            this.miHome.Click += new System.EventHandler(this.miHome_Click);
            // 
            // miSalir
            // 
            this.miSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miSalir.Image = ((System.Drawing.Image)(resources.GetObject("miSalir.Image")));
            this.miSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miSalir.Name = "miSalir";
            this.miSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.miSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSalir.Size = new System.Drawing.Size(122, 132);
            this.miSalir.Text = "&Salir";
            this.miSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // miFecha
            // 
            this.miFecha.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miFecha.Image = ((System.Drawing.Image)(resources.GetObject("miFecha.Image")));
            this.miFecha.ImageTransparentColor = System.Drawing.Color.Black;
            this.miFecha.Name = "miFecha";
            this.miFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.miFecha.Size = new System.Drawing.Size(71, 132);
            this.miFecha.Text = "01-01-17";
            this.miFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.miFecha.Click += new System.EventHandler(this.miFecha_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblAutor.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAutor.Location = new System.Drawing.Point(1237, 136);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAutor.Size = new System.Drawing.Size(131, 13);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Sebastian Cardona Loaiza";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 681);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.mnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnMenu;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnMenu.ResumeLayout(false);
            this.mnMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMenu;
        private System.Windows.Forms.ToolStripMenuItem miRetiro;
        private System.Windows.Forms.ToolStripMenuItem miTest;
        private System.Windows.Forms.ToolStripMenuItem miFactura;
        private System.Windows.Forms.ToolStripMenuItem miViaje;
        private System.Windows.Forms.ToolStripMenuItem miHome;
        private System.Windows.Forms.ToolStripMenuItem miSalir;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.ToolStripMenuItem miFecha;
    }
}

