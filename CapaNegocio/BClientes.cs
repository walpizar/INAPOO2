using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class BClientes : IGenericaNegocio<clsCliente>
    {
        public bool eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsCliente guardar(clsCliente entidad)
        {
            throw new NotImplementedException();
        }

        public clsCliente modificar(clsCliente entidad)
        {
            throw new NotImplementedException();
        }

        public clsCliente obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<clsCliente> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
