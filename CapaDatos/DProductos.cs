using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProductos : IGenericaDatos
    {
        public bool eliminar()
        {
            throw new NotImplementedException();
        }

        public bool guardar(clsProductos producto)
        {
            //persistencia de datos
            return true;
        }
    }
}
