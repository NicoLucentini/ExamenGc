using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGlobalCitizen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        private static Tienda tienda;
        [STAThread]
        static void Main()
        {

            //Cargar valores

            Vendedor vendedor = new Vendedor("Pepe", "Honguito", 1);

            tienda = new Tienda("Atienda", "SanMartin 321");

            tienda.SetVendedor(vendedor);

            tienda.AgregarPrenda(new Camisas(100, 200, true, true));
            tienda.AgregarPrenda(new Camisas(100, 300, true, false));
            tienda.AgregarPrenda(new Camisas(100, 150, false, true));
            tienda.AgregarPrenda(new Camisas(100, 300, false, false));

            tienda.AgregarPrenda(new Pantalones(200, 1500, true));
            tienda.AgregarPrenda(new Pantalones(200, 500, false));


            List<Pantalones> temp = tienda.ObtenerPrenda<Pantalones>( (x)=> x.esChupin );

            foreach (var t in temp) {
                Console.WriteLine(t.ToString());
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(tienda, vendedor));
        }
        
    }
}
