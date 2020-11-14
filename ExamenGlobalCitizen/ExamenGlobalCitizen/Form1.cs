using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGlobalCitizen
{
    public partial class Form1 : Form
    {
        //nico sos el mas lindo y copado de todos

        private bool camisa = true;
        private bool esCuelloMao = false;
        private bool mangaCorta = false;
        private bool chupin = false;
        private bool premium = false;
        private int stock = 0;
        private float precio = 0;
        private int cantidad = 0;

        private Tienda tienda;
        private Vendedor vendedor;


        Prenda prenda = null;

        public Form1()
        {
            InitializeComponent();
        }
        //Esto se deberia realizar con el esquema Correcto MVC 
        public Form1(Tienda tienda, Vendedor vendedor) {
            this.vendedor = vendedor;
            this.tienda = tienda;
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textCantidad.Text = cantidad.ToString();

            this.labelDireccion.Text = tienda.direccion;
            this.labelTienda.Text = tienda.nombre;
            this.labelVendedor.Text = vendedor.nombre + " " + vendedor.apellido;
            this.labelId.Text = vendedor.idVendedor.ToString();

            this.radioButtonCamisas.Checked = true;
            this.radioStandard.Checked = true;
            this.errorCantidad.Text = "";
            this.errorPrecio.Text = "";
            this.errorStock.Text = "";
            this.textErrorCotizacion.Text = "";

            prenda = tienda.ObtenerCamisa(mangaCorta, esCuelloMao);
            CambiarPrecioUnitarioYStock(prenda);
        }

        private void buttonCotizar_Click(object sender, EventArgs e)
        {
            if (stock < cantidad)
            {
                this.textErrorCotizacion.Text = "No hay suficiente stock";
                return;
            }

            this.textErrorCotizacion.Text = "";

            float total = 0;
            total = prenda.Cotizar(premium); //es unitario..
            total *= cantidad;

            this.labelCotizacion.Text = total.ToString("n2");

            //Le agrego cotizacion al vendedor
            
            Cotizacion cotizacion = new Cotizacion(prenda, cantidad, total, vendedor.idVendedor, prenda.ToString() + (premium ? " Premium " : "Standard"));
            vendedor.historial.AgregarCotizacion(cotizacion);


           
        }
        void CambiarPrecioUnitarioYStock(Prenda prenda) {
            stock = prenda == null ? 0 : prenda.stock;
            precio = prenda == null ? 0 : prenda.precio;

            this.labelStock.Text = prenda?.stock.ToString();
            this.labelPrecioUnitario.Text = prenda?.precio.ToString("n2");

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            premium = false;
        }

        private void radioPremium_CheckedChanged(object sender, EventArgs e)
        {
            premium = true;
        }

        private void checkBoxMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            mangaCorta = !mangaCorta;
            if (camisa)
            {
                prenda = tienda.ObtenerCamisa(mangaCorta, esCuelloMao);
                CambiarPrecioUnitarioYStock(prenda);
            }
        }

        private void checkBoxCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            esCuelloMao = !esCuelloMao;

            if (camisa)
            {
                prenda = tienda.ObtenerCamisa(mangaCorta, esCuelloMao);
                CambiarPrecioUnitarioYStock(prenda);
            }
        }

        private void checkBoxChupin_CheckedChanged(object sender, EventArgs e)
        {
            chupin = !chupin;

            if (!camisa)
            {
                prenda = tienda.ObtenerPantalon(chupin);
                CambiarPrecioUnitarioYStock(prenda);
            }
        }

        private void radioButtonCamisas_CheckedChanged(object sender, EventArgs e)
        {
            camisa = true;
            if (camisa)
            {
                prenda = tienda.ObtenerCamisa(mangaCorta, esCuelloMao);
                CambiarPrecioUnitarioYStock(prenda);
            }
        }

        private void radioButtonPantalones_CheckedChanged(object sender, EventArgs e)
        {
            camisa = false;
            if (!camisa)
            {
                prenda = tienda.ObtenerPantalon(chupin);
                CambiarPrecioUnitarioYStock(prenda);
            }
        }

       

        private void textBoxStock_TextChanged(object sender, EventArgs e)
        {
        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {
            string t = this.textCantidad.Text;

            if (int.TryParse(t, out cantidad))
            {
                this.errorCantidad.Text = "";
            }
            else
            {
                this.errorCantidad.Text = "Debe ser un numero entero";
            }

            Console.WriteLine(cantidad);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Historial hist = new Historial(vendedor.historial.cotizaciones);
            hist.Show();
        }

        private void labelVendedor_Click(object sender, EventArgs e)
        {

        }
    }
}
