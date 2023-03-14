using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Modelo
{
    class Camisa : Prenda
    {
        public bool CuelloMao { get; }
        public TipoManga Manga { get; }

        public Camisa(bool cuelloMao, TipoManga manga, bool esPremium, float precioUnitario, int stock = 1) : base(esPremium, precioUnitario, stock)
        {
            CuelloMao = cuelloMao;
            Manga = manga;
            CalcularPrecioUnitarioFinal();
        }

        protected override void CalcularPrecioUnitarioFinal()
        {
            if(Manga == TipoManga.Corta)
            {
                //Restar un 10% del precio
                PrecioUnitario -= PrecioUnitario * 0.1F;
            }

            if(CuelloMao)
            {
                //Aumentar el precio actual en un 3%
                PrecioUnitario += PrecioUnitario * 0.03F;
            }
            
            //Aplicar los cambios del precio que dependen de la calidad
            base.CalcularPrecioUnitarioFinal();
        }
    }

    public enum TipoManga
    {
        Corta,
        Larga
    }
}
