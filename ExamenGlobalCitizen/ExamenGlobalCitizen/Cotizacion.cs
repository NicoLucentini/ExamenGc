using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGlobalCitizen
{
    public class Cotizacion
    {
        static int idCount;

        public int id { get; internal set; } 
        public int idVendedor { get; internal set; }
        public DateTime date { get; internal set; }
        private Prenda prenda;
        public String prendaInfo { get; internal set; }
        public int cantidad { get; internal set; }
        public float total { get; internal set; }

        public Cotizacion(Prenda prenda, int cantidad, float total, int idVendedor, String prendaInfo) {
            id = idCount;
            idCount++;
            date = DateTime.Now;
            this.cantidad = cantidad;
            this.prenda = prenda;
            this.total = total;
            this.idVendedor = idVendedor;
            this.prendaInfo = prendaInfo;
        }

       
    }
}
