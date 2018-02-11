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
    public partial class frmTest : Form
    {
        frmPrincipal objP;
        double cantHem;
        int edad, pos = 0, neg = 0, cant;
        
        public frmTest(frmPrincipal objP)
        {
            InitializeComponent();
            this.objP = objP;
        }

        #region EVENTOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();            
            pbTest.Enabled = true;
            btnLimpiar.Enabled = false;
            btnfinalizar.Visible = false;
            lblResultado.Visible = false;
            lblResultado.Visible = false;            
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            lblResultado.Text = "Examenes positivos: " + pos + "\r" + "\nExamenes negativos: " + neg;
            gbDatos.Enabled = false;
            lblResultado.Visible = true;
            pbTest.Enabled = false;
            btnLimpiar.Visible = true;
            

        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtHemoglobina_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        #endregion

        #region METODOS PRIVADOS
        private void limpiarDatos()
        {
            gbDatos.Enabled = true;                             
            txtNombre.Text = "";            
            txtEdad.Text = "";
            txtHemoglobina.Text = "";
        }
        private void test()
        {
            try
            {
                if (!validar())
                {
                    lblResultado.Visible = true;
                    return;
                }
                cantHem = Double.Parse(txtHemoglobina.Text);
                edad = Int32.Parse(txtEdad.Text);
                detHemoglobina();
                gbDatos.Enabled = false;
                pbTest.Enabled = false;
                btnLimpiar.Visible = true;
                btnLimpiar.Enabled = true;
                btnfinalizar.Visible = true;
                lblResultado.Visible = true;
            }
            catch (Exception ex)
            {

                lblResultado.Visible = true;
                lblResultado.Text = "Error" + ex;
            }
        }
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbTest_MouseClick(object sender, MouseEventArgs e)
        {
            test();
        }
        private void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void detHemoglobina()
        {
            //ENTR 0-1 
            if (edad >= 0 && edad <= 1)
            {
                if (cantHem < 13 || cantHem > 26)
                {
                    lblResultado.Text = "Anemia Positiva";
                    pos++;
                    cant++;

                }
                else
                {
                    lblResultado.Text = "Anemia Negativa";
                    neg++;
                    cant++;
                }
            }

            //ENTRE 1-5
            if (edad > 1 && edad <= 5)
            {
                if (cantHem < 11.5 || cantHem > 15)
                {
                    lblResultado.Text = "Anemia Positiva";
                    pos++;
                    cant++;
                }
                else
                {
                    lblResultado.Text = "Anemia Negativa";
                    neg++;
                    cant++;
                }

            }
            //ENTRE 5-10
            if (edad > 5 && edad <= 10)
            {
                if (cantHem < 12.6 || cantHem > 15.5)
                {
                    lblResultado.Text = "Anemia Positiva";
                    pos++;
                    cant++;
                }
                else
                {
                    lblResultado.Text = "Anemia Negativa";
                    neg++;
                    cant++;
                }
            }
            //ENTRE 10-15
            if (edad > 10 && edad <= 15)
            {
                if (cantHem < 13 || cantHem > 15.5)
                {
                    lblResultado.Text = "Anemia Positiva";
                    pos++;
                    cant++;
                }
                else
                {
                    lblResultado.Text = "Anemia Negativa";
                    neg++;
                    cant++;
                }
            }
            //MUJER MAYOR A 15 
            if (edad > 15 && rbtF.Checked)
            {
                if (cantHem < 12 || cantHem > 16)
                {
                    lblResultado.Text = "Anemia Positiva";
                    pos++;
                    cant++;
                }
                else
                {
                    lblResultado.Text = "Anemia Negativa";
                    neg++;
                    cant++;
                }
            }
            //HOMBRE MAYOR A 15 
            if (edad > 15 && rbtM.Checked)
            {
                if (cantHem < 14 || cantHem > 18)
                {
                    lblResultado.Text = "Anemia Positiva";
                    pos++;
                    cant++;
                }
                else
                {
                    lblResultado.Text = "Anemia Negativa";
                    neg++;
                    cant++;
                }
            }

        }

        private bool validar()
        {
            if (txtNombre.Text == "")
            {
                lblResultado.Text = "Ingrese el nombre del paciente";
                txtNombre.Focus();
                return false;
            }
            if (txtEdad.Text == "")
            {
                lblResultado.Text = "Debe indicar la edad del paciente";
                txtEdad.Focus();
                return false;
            }
            if (!rbtF.Checked && !rbtM.Checked)
            {
                lblResultado.Text = "Por favor, indique el genero";
                return false;
            }
            if (txtHemoglobina.Text == "")
            {
                lblResultado.Text = "Digite el nivel de hemoglobina";
                txtHemoglobina.Focus();
                return false;
            }
            return true;
        }
        #endregion

    }
}
