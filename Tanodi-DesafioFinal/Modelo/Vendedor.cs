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
        private Tienda _tienda;

        public List<Cotizacion> HistorialCotizaciones { get; private set; }

        public Vendedor(string nombre, string apellido, int codigo, Tienda tienda)
        {
            Nombre = nombre;
            Apellido = apellido;
            Codigo = codigo;
            _tienda = tienda;

            HistorialCotizaciones = new List<Cotizacion>();
        }

        public Cotizacion NuevaCotizacion(Prenda prenda, int cantidad)
        {
            int idUltimaCotizacion;

            if(HistorialCotizaciones.Count > 0)
            {
                idUltimaCotizacion = HistorialCotizaciones[HistorialCotizaciones.Count - 1].ID;
            }
            else
            {
                idUltimaCotizacion = 0;
            }

            Cotizacion nuevaCotizacion = new Cotizacion(idUltimaCotizacion + 1, DateTime.Now, Codigo, prenda, cantidad);

            HistorialCotizaciones.Add(nuevaCotizacion);

            return nuevaCotizacion;
        }

    }
}
