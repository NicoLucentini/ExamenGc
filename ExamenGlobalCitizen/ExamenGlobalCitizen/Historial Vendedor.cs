using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGlobalCitizen
{
    public class Historial_Vendedor
    {
        public List<Cotizacion> cotizaciones { get; internal set; }

        public Historial_Vendedor() {
            cotizaciones = new List<Cotizacion>();
        }
        public void AgregarCotizacion(Cotizacion cotizacion) {
            cotizaciones.Add(cotizacion);
        }
    }
}
