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
    public partial class frmRetiro : Form
    {
        frmPrincipal objP;

        public frmRetiro(frmPrincipal objP)
        {
            InitializeComponent();
            this.objP = objP;
        }

        int v10 = 10000, v5 = 5000, v2 = 2000, v1 = 1000,b10 = 0, b5 = 0, b2 = 0, b1 = 0, cantR;
        
        private void pbRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                cantR = Int32.Parse(txtCant.Text.Trim());
                if (!validar())
                {
                    gbpBilletes.Visible = false;
                    btnNuevo.Visible = false;
                    return;
                }
                if (cantR >= 1 && cantR <= 499)
                {
                    lblMensaje.Text = "Cantidad no permitida";
                    txtCant.Enabled = false;
                    lblMensaje.Visible = true;
                    gbpBilletes.Visible = false;
                    pbRetirar.Enabled = false;
                    btnNuevo.Visible = true;
                    return;
                }

                do
                {
                    determinarCant();

                    if (cantR >= 500 && cantR <= 999) //Redondeo e impresión
                    {
                        b1++;
                        visibles();
                    }
                    else
                    {
                        visibles();
                    }
                } while (cantR != 0);

            }
            catch (Exception)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Valor no permitido "; //2.147.483.648 max valor permitido
                                                         /*capacidad máxima a la que funcionan los sistemas informáticos
                                                           con una arquitectura de 32 bit*/
                txtCant.Focus();
            }
        }
    


        #region EVENTOS

        private void frmRetiro_Load(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            lblMensaje.Visible = false;
        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            b10 = 0;
            b5 = 0;
            b2 = 0;
            b1 = 0;
            cantR = 0;
            gbpBilletes.Visible = false;
            txtCant.Enabled = true;
            pbRetirar.Enabled = true;
            btnNuevo.Visible = false;
            lblMensaje.Visible=false;
            txtCant.Focus();
            txtCant.Text = "";
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }     
       
            
        #endregion

        #region METODOS PRIVADOS
        private void determinarCant()
        {
            b10 = cantR / v10;                  //Cantidad de billetes de 10000
            cantR = cantR % v10;
            if (cantR > 0)                      //Cantidad de billetes de 5000
            {
                b5 = cantR / v5;
                cantR = cantR % v5;
            }
            if (cantR > 0)                      //Cantidad de billetes de 2000
            {
                b2 = cantR / v2;
                cantR = cantR % v2;
            }   
            if (cantR > 0)                      //Cantidad de billetes de 1000
            {
                b1 = cantR / v1;
                cantR = cantR % v1;
            }
        }
        private void visibles()
        {
            if (b10 == 0)
            {
                pbB10.Visible = false;
                lblB10.Visible = false;
            }
            else
            {
                pbB10.Visible = true;
                lblB10.Visible = true;
                lblB10.Text = "x " + b10;
            }
            if (b5 == 0)
            {
                pbB5.Visible = false;
                lblB5.Visible = false;
            }
            else
            {
                pbB5.Visible = true;
                lblB5.Visible = true;
                lblB5.Text = "x " + b5;
            }
            if (b2 == 0)
            {
                pbB2.Visible = false;
                lblB2.Visible = false;
            }
            else
            {
                pbB2.Visible = true;
                lblB2.Visible = true;
                lblB2.Text = "x " + b2;
            }
            if (b1 == 0)
            {
                pbB1.Visible = false;
                lblB1.Visible = false;
            }
            else
            {
                pbB1.Visible = true;
                lblB1.Visible = true;
                lblB1.Text = "x " + b1;
            }
            gbpBilletes.Visible = true;
            txtCant.Enabled = false;
            pbRetirar.Enabled = false;
            btnNuevo.Visible = true;
            lblMensaje.Visible = false;
            cantR = 0;
        }
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool validar()
        {
            if (cantR > 0)
            {
                return true;
            }
            gbpBilletes.Visible = false;
            lblMensaje.Visible = true;
            lblMensaje.Text = "Cantidad no permitida";
            return false;
        }
        #endregion

    }
}
