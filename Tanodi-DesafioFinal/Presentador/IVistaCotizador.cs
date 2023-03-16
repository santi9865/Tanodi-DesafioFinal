using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Presentador
{
    interface IVistaCotizador
    {
        void MostrarMontoTotal(float monto);
        void ActivarCotizacion();
        void MostrarError(string mensaje);
        void ActualizarTienda(string nombre, string direccion);
        void ActualizarVendedor(string nombre, string apellido, string codigo);

        void ActualizarStock(string stock);
    }
}
