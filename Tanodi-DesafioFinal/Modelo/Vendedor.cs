using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Modelo
{
    class Vendedor
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int Codigo { get; private set; } //Código identificatorio del vendedor
        private Tienda tienda;

        public List<Cotizacion> HistorialCotizaciones { get; private set; }
    }
}
