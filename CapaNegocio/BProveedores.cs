using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class BProveedores : IGenericaNegocio<clsProveedor>
    {
        public bool eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsProveedor guardar(clsProveedor entidad)
        {
            throw new NotImplementedException();
        }

        public clsProveedor modificar(clsProveedor entidad)
        {
            throw new NotImplementedException();
        }

        public clsProveedor obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<clsProveedor> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
