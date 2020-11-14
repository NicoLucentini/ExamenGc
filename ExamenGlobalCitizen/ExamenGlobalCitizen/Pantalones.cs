using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGlobalCitizen
{
    class Pantalones : Prenda
    {
        public bool esChupin { get; internal set; }

        public Pantalones(float precio, int stock,  bool esChupin) : base(precio, stock)
        {
            this.esChupin = esChupin;
        }

      

        public override float Cotizar(bool esPremium)
        {
            float precioFinal = precio;

            if (esChupin)
                precioFinal *= .88f;
            
            return precioFinal * base.Cotizar(esPremium);
        }

        public override string ToString()
        {
            return "Pantalon " + (esChupin ? "Chupin" : "Comun");
        }
    }
}
