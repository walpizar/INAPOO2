using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class DProveedores : IGenericaDatos<tbProveedores>
    {
        public bool eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public tbProveedores guardar(tbProveedores entidad)
        {
            throw new NotImplementedException();
        }

        public tbProveedores modificar(tbProveedores entidad)
        {
            throw new NotImplementedException();
        }

        public tbProveedores obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbProveedores> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
