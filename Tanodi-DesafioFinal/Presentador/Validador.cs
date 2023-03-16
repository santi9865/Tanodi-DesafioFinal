using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanodi_DesafioFinal.Presentador
{
    static class Validador
    {

        public static bool ValidarInt(string valor, ref int resultado)
        {
            int valorInt;
            try
            {
                valorInt = int.Parse(valor);
                resultado = valorInt;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidarFloat(string valor, ref float resultado)
        {
            float valorFloat;
            try
            {
                valorFloat = float.Parse(valor);
                resultado = valorFloat;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
