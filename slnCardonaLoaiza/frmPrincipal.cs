using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnCardonaLoaiza
{
    public partial class frmPrincipal : Form
    {
        DateTime Hoy = DateTime.Today;
        public int desblock = 0,f1=0,f2=0,f3=0,f4=0;        

        public frmPrincipal()
        {
            InitializeComponent();            
        }

        #region EVENTOS
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string fecha_actual = Hoy.ToString("dd-MM-yyyy");
            miFecha.Text = fecha_actual;
        }


        private void miRetiro_Click(object sender, EventArgs e)
        {  
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmRetiro) //comprueba si ya está abierto
                {
                    open = true;
                }               
            }
            if (!open)
            {
                Form frm = new frmRetiro(this);
                
                frm.MdiParent = this;
                frm.Show();
                miRetiro.Enabled = true;
                miTest.Enabled = false;
                miFactura.Enabled = false;
                miViaje.Enabled = false;
            }
        }

        private void miTest_Click(object sender, EventArgs e)
        {  
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmTest) 
                {
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmTest(this);

                frm.MdiParent = this;
                frm.Show();
                miRetiro.Enabled = false;
                miTest.Enabled = true;
                miFactura.Enabled = false;
                miViaje.Enabled = false;
            }
        }

        private void miFactura_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmFacturador) 
                {
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmFacturador(this);
                frm.MdiParent = this;
                frm.Show();
                miRetiro.Enabled = false;
                miTest.Enabled = false;
                miFactura.Enabled = true;
                miViaje.Enabled = false;
            }
        }

        private void miViaje_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmViaje) 
                {
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmViaje(this);
                frm.MdiParent = this;
                frm.Show();
                miRetiro.Enabled = false;
                miTest.Enabled = false;
                miFactura.Enabled = false;
                miViaje.Enabled = true;
            }
        }


        private void miFecha_Click(object sender, EventArgs e)
        {
            desblock++;            
            if (desblock == Hoy.Day)
            {
                miFecha.ImageScaling = 0;
            }                
        }

        private void miHome_Click(object sender, EventArgs e)
        {
            miRetiro.Enabled = true;
            miTest.Enabled = true;
            miFactura.Enabled = true;
            miViaje.Enabled = true;

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?","Cerrar programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        #endregion

    }
}

