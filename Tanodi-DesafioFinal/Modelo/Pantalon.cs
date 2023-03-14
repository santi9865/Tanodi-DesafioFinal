using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Modelo
{
    class Pantalon : Prenda
    {
        public bool EsChupin { get; }

        public Pantalon(bool esPremium, float precioUnitario, bool esChupin, int stock = 1) : base(esPremium, precioUnitario, stock)
        {
            EsChupin = esChupin;
            CalcularPrecioUnitarioFinal();
        }

        protected override void CalcularPrecioUnitarioFinal()
        {
            if(EsChupin)
            {
                //Restar el 12% del precio;
                PrecioUnitario -= PrecioUnitario * 0.12F;
            }

            //Aplicar los cambios del precio que dependen de la calidad
            base.CalcularPrecioUnitarioFinal();
        }
    }
}
