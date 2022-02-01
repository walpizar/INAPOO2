using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Exceptions
{
    public class EntityExistException : Exception
    {
        public EntityExistException(string entidad):base(entidad +" ya se encuentra(o) almanacenada en la base datos.")
        {
        }
    }
}
