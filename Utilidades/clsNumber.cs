using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class clsNumber
    {
        public static bool isNumber(string valor)
        {
            try
            {
                decimal.Parse(valor);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

    }
}
