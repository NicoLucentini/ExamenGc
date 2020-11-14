using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGlobalCitizen
{
    public class Prenda
    {
        public int stock { get; internal set; }
        public float precio { get; internal set; }

      
        public Prenda(float precio, int stock)
        {
            this.precio = precio;
            this.stock = stock;
            RandomPremium();
        }
        public void RandomPremium() {
            Random r = new Random();
            int res = r.Next(2);
        }

        public virtual float Cotizar(bool esPremium) {
            return esPremium ? 1.3f : 1;
        }
    }
}
