using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class DProductos : IGenericaDatos<clsProductos>
    {
        public bool eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsProductos guardar(clsProductos entidad)
        {
            //hace la persistencia
            return null;
        }

        public clsProductos modificar(clsProductos entidad)
        {
            throw new NotImplementedException();
        }

        public clsProductos obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<clsProductos> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
