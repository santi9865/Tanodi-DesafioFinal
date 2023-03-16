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
        }

        public void NuevaCotizacion(int id, DateTime fechaYHora, Prenda prenda, int cantidad)
        {
            Cotizacion nuevaCotizacion = new Cotizacion(id, fechaYHora, Codigo, prenda, cantidad);

            HistorialCotizaciones.Add(nuevaCotizacion);
        }

    }
}
