using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class clsMath
    {
        //public static int fdsfd { get; set; }
        //no necesito constructor

        public static bool verificarNumeroPar(int num)
        {

            decimal residuo = num % 2;

            return residuo == 0 ? true: false;


        }




    }
}
