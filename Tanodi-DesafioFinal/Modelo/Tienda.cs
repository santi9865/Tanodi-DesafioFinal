using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Modelo
{
    class Tienda
    {
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }

        private List<Vendedor> _vendedores;

        private List<Prenda> _prendas;

        public Tienda(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public void NuevaPrenda(Prenda prenda)
        {
            _prendas.Add(prenda);
        }

        public void NuevoVendedor(Vendedor vendedor)
        {
            _vendedores.Add(vendedor);
        }

    }
}
