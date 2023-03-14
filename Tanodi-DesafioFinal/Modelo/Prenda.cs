using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Modelo
{
    abstract class Prenda
    {
        public bool EsPremium { get; }
        public float PrecioUnitario {get; protected set; }
        public int Stock { get; }

        public Prenda(bool esPremium, float precioUnitario, int stock = 1)
        {
            EsPremium = esPremium;
            PrecioUnitario = precioUnitario;
            Stock = stock;
        }

        protected virtual void CalcularPrecioUnitarioFinal()
        {
            if(EsPremium)
            {
                //Aumentar el precio actual en un 30%
                PrecioUnitario += PrecioUnitario * 0.3F;
            }
        }
    }
}
