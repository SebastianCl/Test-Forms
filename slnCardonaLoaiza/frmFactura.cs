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
    public partial class frmFacturador : Form
    {
        frmPrincipal objP;
        int cod,cant;
        double subtotal=0, total=0;
        const double IVA = 0.19;
        
        productos[] vecPro = new productos[10];

        public frmFacturador(frmPrincipal objP)
        {
            InitializeComponent();
            this.objP = objP;
        }

        #region EVENTOS
        private void frmFacturador_Load(object sender, EventArgs e)
        {
            productos();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            txtFactura.Visible = true;
            gpDatos.Enabled = false;
            btnFacturar.Enabled = false;
            btnLimpiar.Visible = true;
            nupCodigo.Value = 1;
            txtCantidad.Text = "";
            lblConfirmacion.Visible = false;
            txtFactura.AppendText("\n______________________________________________" + "\r" + "\nSubtotal: \t \t" + subtotal.ToString("c") + "\r"
                                              + "\n___________________________________" + "\r" + "\nTOTAL: \t \t" + total.ToString("c"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {            
            gpDatos.Enabled = true;
            lblConfirmacion.Visible = false;
            btnFacturar.Enabled = false;
            pbRegistrar.Enabled = true;
            txtFactura.Text = "";
            txtFactura.Visible = false;
            nupCodigo.Value = 1;
            txtCantidad.Text = "";
            btnLimpiar.Visible = false;
            total = 0;
            subtotal = 0;

        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void pbRegistrar_MouseClick(object sender, MouseEventArgs e)
        {
            registrar();
        }


        #endregion

        #region METODOS PRIVADOS
        private void registrar()
        {
            try
            {
                if (!validarCampos())
                {
                    return;
                }

                cod = (int)nupCodigo.Value;
                cant = Int32.Parse(txtCantidad.Text);
                if (cant == 0)
                {
                    lblConfirmacion.Text = "La cantidad no puede ser cero";
                    lblConfirmacion.ForeColor = Color.Black;
                    lblConfirmacion.Visible = true;
                    txtCantidad.Focus();
                    return;
                }

                if (!validarTamVector())
                {
                    nupCodigo.Focus();
                    return;
                }

                nupCodigo.Focus();                
                
                for (int i = 0; i < vecPro.Length; i++)  
                {
                    if (vecPro[i].getCodigo() == cod)   //busco el producto
                    {                                               
                        lblConfirmacion.Visible = true;
                        
                        if (vecPro[i].getCantExistente() <= 0)  //valido si hay productos
                        {
                            lblConfirmacion.Text = "AGOTADO";
                            lblConfirmacion.ForeColor = Color.Red;
                            nupCodigo.Focus();
                            txtCantidad.Text = "";                          
                                                                                
                        }
                        else
                        {
                            if (cant > vecPro[i].getCantExistente()) //valido si hay suficientes productos
                            {
                                lblConfirmacion.Text = "Cantidad no disponible";
                                txtCantidad.Focus();
                                lblConfirmacion.ForeColor = Color.Black;
                            }
                            else
                            {
                                subtotal = subtotal + vecPro[i].getValor() * cant;
                                total = total + subtotal - (subtotal * vecPro[i].getDescuento());
                                total = total + total * IVA;
                                vecPro[i].setCantExistente(vecPro[i].getCantExistente() - cant);  //retiro los productos vendidos

                                lblConfirmacion.ForeColor = Color.Black;
                                lblConfirmacion.Text = "Producto registrado";
                                txtFactura.Text = txtFactura.Text + "\n" + vecPro[i].getNombre() + "\t \t " + vecPro[i].getValor().ToString("c") + "\t X " + cant + "\r";
                                txtFactura.Visible = true;
                                btnFacturar.Enabled = true;
                            }
                        }
                                 
                    }
                }
            }
            catch (Exception)
            {                
                lblConfirmacion.Text = "Asegurese de ingresar de forma correcta los valores";
                lblConfirmacion.Visible = true;
                txtCantidad.Focus();
                lblConfirmacion.ForeColor = Color.Black;
            }
        }

        private void productos()
        {
            productos objPro1 = new productos();

            objPro1.setCodigo(1);
            objPro1.setNombre("Leche");
            objPro1.setValor(2000);
            objPro1.setDescuento(0.05);
            objPro1.setCantExistente(500);
            vecPro[0] = objPro1;

            productos objPro2 = new productos();
            objPro2.setCodigo(2);
            objPro2.setNombre("Chocolate");
            objPro2.setValor(1000);
            objPro2.setDescuento(0.0);
            objPro2.setCantExistente(300);
            vecPro[1] = objPro2;

            productos objPro3 = new productos();
            objPro3.setCodigo(3);
            objPro3.setNombre("Papel");
            objPro3.setValor(1200);
            objPro3.setDescuento(0.1);
            objPro3.setCantExistente(1000);
            vecPro[2] = objPro3;

            productos objPro4 = new productos();
            objPro4.setCodigo(4);
            objPro4.setNombre("Azucar");
            objPro4.setValor(1700);
            objPro4.setDescuento(0.05);
            objPro4.setCantExistente(250);
            vecPro[3] = objPro4;

            productos objPro5 = new productos();
            objPro5.setCodigo(5);
            objPro5.setNombre("Pan");
            objPro5.setValor(2500);
            objPro5.setDescuento(0.1);
            objPro5.setCantExistente(100);
            vecPro[4] = objPro5;

            productos objPro6 = new productos();
            objPro6.setCodigo(6);
            objPro6.setNombre("Sal");
            objPro6.setValor(1200);
            objPro6.setDescuento(0.0);
            objPro6.setCantExistente(2000);
            vecPro[5] = objPro6;

            productos objPro7 = new productos();
            objPro7.setCodigo(7);
            objPro7.setNombre("Gaseosa");
            objPro7.setValor(1500);
            objPro7.setDescuento(0.0);
            objPro7.setCantExistente(3000);
            vecPro[6] = objPro7;

            productos objPro8 = new productos();
            objPro8.setCodigo(8);
            objPro8.setNombre("Galletas");
            objPro8.setValor(800);
            objPro8.setDescuento(0.1);
            objPro8.setCantExistente(5000);
            vecPro[7] = objPro8;

            productos objPro9 = new productos();
            objPro9.setCodigo(9);
            objPro9.setNombre("Carne");
            objPro9.setValor(8000);
            objPro9.setDescuento(0.2);
            objPro9.setCantExistente(300);
            vecPro[8] = objPro9;

            productos objPro10 = new productos();
            objPro10.setCodigo(10);
            objPro10.setNombre("Papa");
            objPro10.setValor(2000);
            objPro10.setDescuento(0.3);
            objPro10.setCantExistente(1000);
            vecPro[9] = objPro10;
        }

        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                registrar();
            }
        }
               

        private bool validarCampos()
        {
            if (nupCodigo.Value == 0)
            {
                lblConfirmacion.Text = "Indique el código del producto";
                lblConfirmacion.Visible = true;
                lblConfirmacion.ForeColor = Color.Black;
                nupCodigo.Focus();
                return false;
            }
            if (txtCantidad.Text == string.Empty)
            {
                lblConfirmacion.Text = "Indique la cantidad de productos";
                lblConfirmacion.ForeColor = Color.Black;
                lblConfirmacion.Visible = true;
                txtCantidad.Focus();
                return false;
            }
            return true;
        }

        private bool validarTamVector()
        {
            if (cod <= 0 || cod > 10 )
            {
                lblConfirmacion.Text = "Producto no existente";
                lblConfirmacion.Visible = true;
                return false;
            }
            return true;
        }
        #endregion


    }


    class productos
    {
        int codigo;
        int cantExistente;
        string nombre;
        double valor,descuento;        

        #region PROPIEDADES
        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCantExistente()
        {
            return cantExistente;
        }
        public void setCantExistente (int cantExistente)
        {
            this.cantExistente = cantExistente;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public double getValor()
        {
            return valor;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public double getDescuento()
        {
            return descuento;
        }
        public void setDescuento(double descuento){
            this.descuento = descuento;
        }

        #endregion

    }
}
