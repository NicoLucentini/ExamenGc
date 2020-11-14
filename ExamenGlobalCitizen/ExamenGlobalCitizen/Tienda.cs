using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExamenGlobalCitizen
{
    public class Tienda
    {
        public string nombre { get; internal set; }
        public string direccion { get; internal set; }
        private List<Prenda> prendas;

        private  Vendedor vendedor;
        
        public Tienda(string nombre, string direccion) {
            this.nombre = nombre;
            this.direccion = direccion;

            prendas = new List<Prenda>();
        }

        public void AgregarPrenda(Prenda prenda) {
            prendas.Add(prenda);
        }

        public void SetVendedor(Vendedor vendedor) {
            this.vendedor = vendedor;
        }
       
        public Prenda ObtenerCamisa(bool mangaCorta, bool mao) {
            foreach (var p in prendas) {

                if (!(p is Camisas)) continue;

                Camisas temp = (Camisas)p;

                if (temp.esMangaCorta == mangaCorta && temp.tieneCuelloMao == mao)
                    return p;
            }
            return null;
        }

        public Prenda ObtenerPantalon(bool chupin)
        {
            foreach (var p in prendas)
            {
                if (!(p is Pantalones)) continue;

                Pantalones temp = (Pantalones)p;

                if (temp.esChupin == chupin)
                    return p;
            }
            return null;
        }

    }
}
