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
    public partial class frmViaje : Form
    {
        frmPrincipal objP;
        viaje objViaje;
        string nombre, cedula, destino;
        int diasEstadia;
        double valorTransporte, tipoHabitacion, tipoCam;
        int menu;
        DateTime FV;

        public frmViaje(frmPrincipal objP)
        {
            InitializeComponent();
            this.objP = objP;
        }


        #region EVENTOS
        private void rbBarco_MouseClick(object sender, MouseEventArgs e)
        {
            gbBarco.Visible = true;
            gbAvion.Visible = false;
            gbDatos.Enabled = true;
            btnConsultar.Enabled = true;
        }

        private void rbAvion_MouseClick(object sender, MouseEventArgs e)
        {
            gbBarco.Visible = false;
            gbAvion.Visible = true;
            gbDatos.Enabled = true;
            btnConsultar.Enabled = true;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
        private void txtNumDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtTransporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtDiasBarco_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtTasaAero_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtValorMillas_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtDestino.Text = "";
            txtNumDias.Text = "";
            txtTransporte.Text = "";
            gbDatos.Enabled = false;
            gbAvion.Visible = false;
            gbBarco.Visible = false;
            lblSalida.Visible = false;
            btnConsultar.Enabled = false;
            btnLimpiar.Visible = false;
            txtDiasBarco.Text = "";
            txtValorMillas.Text = "";
            txtTasaAero.Text = "";
            cmbCamarote.SelectedIndex = 0;
            txtValorMillas.Text = "";
            txtCantidadMillas.Text = ""
;        }

        private void pbAvion_MouseClick(object sender, MouseEventArgs e)
        {
            menu = 1;
            gbAvion.Visible = true;
            gbBarco.Visible = false;
            gbDatos.Enabled = true;
            btnConsultar.Enabled = true;
        }

        private void pbBarco_MouseClick(object sender, MouseEventArgs e)
        {
            menu = 2;
            gbAvion.Visible = false;
            gbBarco.Visible = true;
            gbDatos.Enabled = true;
            btnConsultar.Enabled = true;
        }

       
        
        private void frmViaje_Load(object sender, EventArgs e)
        {
            cmbCamarote.Items.Add("Seleccione"); 
            cmbCamarote.Items.Add("Normal");
            cmbCamarote.Items.Add("Lujo");
            cmbCamarote.Items.Add("Económica");
            cmbCamarote.SelectedIndex = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (menu == 1)
                {
                    if (!validarCamposDatos())
                    {
                        return;
                    }

                    nombre = txtNombre.Text;
                    cedula = txtCedula.Text;
                    destino = txtDestino.Text;
                    diasEstadia = Int32.Parse(txtNumDias.Text);
                    valorTransporte = Double.Parse(txtTransporte.Text);
                    FV = dtpFechaViaje.Value;
                    if (rbNormal.Checked)
                    {
                        tipoHabitacion = 55000;
                    }
                    else
                    {
                        tipoHabitacion = 90000;
                    }
                    if (!validarCamposAvion())  //valido gbAvion
                    {
                        return;
                    }
                    double tasaAero = Double.Parse(txtTasaAero.Text);
                    double valorMillas = Double.Parse(txtValorMillas.Text);
                    int cantidadMillas = Int32.Parse(txtCantidadMillas.Text);

                   

                    viaje objAvion = new avion(nombre, cedula, destino, diasEstadia, valorTransporte, tipoHabitacion, FV, tasaAero, valorMillas, cantidadMillas);
                    
                    objViaje = objAvion; 
                                                            
                    lblSalida.Visible = true;
                    lblSalida.Text = "El costo de la excursión con viaje en avión es de: \r" + "\n" + objViaje.calcular().ToString("c");
                }
                else
                {
                    if (!validarCamposDatos())
                    {
                        return;
                    }
                    nombre = txtNombre.Text;
                    cedula = txtCedula.Text;
                    destino = txtDestino.Text;
                    diasEstadia = Int32.Parse(txtNumDias.Text);
                    valorTransporte = Double.Parse(txtTransporte.Text);
                    FV = dtpFechaViaje.Value;
                    if (rbNormal.Checked)
                    {
                        tipoHabitacion = 55000;
                    }
                    else
                    {
                        tipoHabitacion = 90000;
                    }


                    if (!validarCamposBarco()) //valido gpBarco
                    {
                        return;
                    }

                    if (cmbCamarote.SelectedIndex == 1)
                    {
                        tipoCam = 60000;
                    }
                    if (cmbCamarote.SelectedIndex == 2)
                    {
                        tipoCam = 70000;
                    }
                    if (cmbCamarote.SelectedIndex == 3)
                    {
                        tipoCam = 40000;
                    }
                    int numDias = Int32.Parse(txtNumDias.Text);
                    viaje objBarco = new barco(nombre, cedula, destino, diasEstadia, valorTransporte, tipoHabitacion, FV, numDias, tipoCam);
                    objViaje = objBarco;                                                                      
                    lblSalida.Visible = true;
                    lblSalida.Text = "El costo de la excursión con viaje en barco es de: \r" + "\n" + objViaje.calcular().ToString("c");


                }
                btnLimpiar.Visible = true;
                lblMensaje.Visible = false;

            }
            catch (Exception)
            {

                btnLimpiar.Visible = true;
                lblMensaje.Visible = false;
                lblMensaje.Text = "Digite correctamente los valores";
            }
        }

        

        #endregion

        #region METODOS PRIVADOS
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validarCamposAvion()
        {
            if (txtTasaAero.Text == "")
            {
                lblMensaje.Text = "Debe ingresar el valor de la tasa aeroportuaria";
                lblMensaje.Visible = true;
                txtTasaAero.Focus();
                return false;
            }
            if (txtValorMillas.Text == "")
            {
                lblMensaje.Text = "Debe ingresar el valor de las millas";
                txtValorMillas.Focus();
                lblMensaje.Visible = true;
                return false;
            }
            if (txtCantidadMillas.Text == "")
            {
                lblMensaje.Text = "Debe ingresar la cantidad de millas";
                txtCantidadMillas.Focus();
                lblMensaje.Visible = true;
                return false;
            }
            return true;
        }

        private bool validarCamposBarco()
        {
            if (txtDiasBarco.Text == "")
            {
                lblMensaje.Text = "Debe indicar el número de días";
                txtDiasBarco.Focus();
                lblMensaje.Visible = true;
                return false;
            }
            if (cmbCamarote.SelectedIndex == 0)
            {
                lblMensaje.Text = "Seleccione el tipo de camarote";
                lblMensaje.Visible = true;
                return false;
            }
            return true;
        }
        private bool validarCamposDatos()
        {
            if (txtNombre.Text == "")
            {
                lblMensaje.Text = "Debe ingresar el nombre";
                txtNombre.Focus();
                lblMensaje.Visible = true;
                return false;
            }
            if (txtCedula.Text == "")
            {
                lblMensaje.Text = "Debe ingresar la cedula";
                txtCedula.Focus();
                lblMensaje.Visible = true;
                return false;
            }
            if (txtDestino.Text == "")
            {
                lblMensaje.Text = "Debe ingresar el destino";
                txtDestino.Focus();
                lblMensaje.Visible = true;
                return false;
            }
            if (!rbNormal.Checked && !rbSuite.Checked)
            {
                lblMensaje.Text = "Seleccione un tipo de habitación";
                lblMensaje.Visible = true;
                return false;
            }
            if (txtNumDias.Text == "")
            {
                lblMensaje.Text = "Debe ingresar el número de días";
                lblMensaje.Visible = true;
                txtNumDias.Focus();
                return false;
            }
            if (txtTransporte.Text == "")
            {
                lblMensaje.Text = "Debe ingresar el valor del transporte";
                lblMensaje.Visible = true;
                txtTransporte.Focus();
                return false;
            }
            return true;
        }
        #endregion


    }

        #region CLASES
    public abstract class viaje
    {

        #region ATRIBUTOS
        string nombre, cedula, destino;
        double valorTransporte, tipoHabitacion;
        int diasEstadia;
        DateTime FV;
        #endregion

        #region CONSTRUCTOR
        public viaje(string nombre, string cedula, string destino, int diasEstadia, double valorTransporte, double tipoHabitacion, DateTime FV)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.destino = destino;
            this.diasEstadia = diasEstadia;
            this.valorTransporte = valorTransporte;
            this.tipoHabitacion = tipoHabitacion;
            this.FV = FV;
        }

        #endregion

        #region PROPIEADES
        public DateTime getFechaViaje()
        {
            return FV;
        }
        public void setFechaViaje(DateTime FV)
        {
            this.FV = FV;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getCedula()
        {
            return cedula;
        }
        public void setCedula(string cedula)
        {
            this.cedula = cedula;
        }

        public string getDestino()
        {
            return destino;
        }
        public void setDestino(string destino)
        {
            this.destino = destino;
        }

        public int getDiasEstadia()
        {
            return diasEstadia;
        }
        public void setDiasEstadia(int diasEstadia)
        {
            this.diasEstadia = diasEstadia;
        }

        public double getValorTransporte()
        {
            return valorTransporte;
        }
        public void setValorTransporte(double valorTransporte)
        {
            this.valorTransporte = valorTransporte;
        }

        public double getTipoHabitacion()
        {
            return tipoHabitacion;
        }
        public void setTipoHabitacion(double tipoHabitacion)
        {
            this.tipoHabitacion = tipoHabitacion;
        }
        #endregion

        public abstract double calcular();
    }

    public class avion : viaje
    {
        double tasaAero, valorMillas;
        int cantidadMillas;

        #region PROPIEDADES
        public double getTasaAero()
        {
            return tasaAero;
        }
        public void setTasaAero(double tasaAero)
        {
            this.tasaAero = tasaAero;
        }
        public double getValorMillas()
        {
            return valorMillas;
        }
        public void setValorMillas(double valorMillas)
        {
            this.valorMillas = valorMillas;
        }

        #endregion

        public avion(string nombre, string cedula, string destino, int diasEstadia, double valorTransporte, double tipoHabitacion, DateTime FV,double tasaAero, double valorMillas, int cantidadMillas)
                : base(nombre, cedula, destino, diasEstadia, valorTransporte, tipoHabitacion,FV)
        {
            this.tasaAero = tasaAero;
            this.valorMillas = valorMillas;
            this.cantidadMillas = cantidadMillas;
        }

        public override double calcular()
        {
            double total = getDiasEstadia() * getTipoHabitacion() + valorMillas * cantidadMillas + tasaAero + getValorTransporte();

            return total;
        }
    }

    public class barco : viaje
    {
        double tipoCam;
        int numDias; 

        #region PROPIEDADES
        public int getNumDias()
        {
            return numDias;
        }
        public void setNumDias(int numDias)
        {
            this.numDias = numDias;
        }
        public double getTipoCam()
        {
            return tipoCam;
        }
        public void setTipoCam(double tipoCam)
        {
            this.tipoCam = tipoCam;
        }
        #endregion

        public barco(string nombre, string cedula, string destino, int diasEstadia, double valorTransporte, double tipoHabitacion, DateTime FV, int numDias, double tipoCam)
                : base(nombre, cedula, destino, diasEstadia, valorTransporte, tipoHabitacion,FV)
        {
            this.tipoCam = tipoCam;
            this.numDias = numDias;
        }

        public override double calcular()
        {
            double total = getDiasEstadia() * getTipoHabitacion() + numDias * tipoCam + getValorTransporte();
            return total;
        }
    }
    #endregion

}
