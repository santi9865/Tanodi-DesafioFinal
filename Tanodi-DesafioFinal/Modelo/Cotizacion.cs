using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Modelo
{
    class Cotizacion
    {
        public int ID { get; private set; } //Número de identificación
        public DateTime FechaYHora { get; private set; } //Fecha y hora de creación
        public int CodigoVendedor { get; private set; } //Codigo del vendedor que genero esta cotización
        public Prenda Prenda { get; private set; }
        public int Cantidad { get; private set; }
        public float Resultado { get; private set; }
    }
}
