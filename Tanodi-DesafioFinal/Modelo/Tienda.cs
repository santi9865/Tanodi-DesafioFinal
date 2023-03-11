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

        private List<Vendedor> vendedores;

        private List<Prenda> prendas;

    }
}
