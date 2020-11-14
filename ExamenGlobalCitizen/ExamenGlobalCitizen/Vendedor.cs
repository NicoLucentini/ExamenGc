using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGlobalCitizen
{
    public class Vendedor
    {
        public string nombre { get; internal set; }
        public string apellido { get; internal set; }
        public int idVendedor { get; internal set; }

        public Historial_Vendedor historial { get; internal set; }

        public Vendedor(string nombre, string apellido, int idVendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.idVendedor = idVendedor;
            historial = new Historial_Vendedor();
        }

        public void AgregarCotizacion(Cotizacion cotizacion) {
            historial.AgregarCotizacion(cotizacion);
        }
    }
}
