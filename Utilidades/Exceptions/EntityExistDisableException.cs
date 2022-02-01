using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Exceptions
{
    public class EntityExistDisableException : Exception
    {
        public EntityExistDisableException(string entidad): base(entidad+" existe pero se encuetra deshabilitada(o).")
        {
        }
    }
}
