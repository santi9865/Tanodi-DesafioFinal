using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Modelo
{
    class Prenda
    {
        public Calidad Calidad { get; private set; }
        public float PrecioUnitario { get; private set; }
        public int Stock { get; private set; }
    }

    public enum Calidad
    {
        Standard,
        Premium
    }
}
