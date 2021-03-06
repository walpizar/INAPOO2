using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class BProveedores : IGenericaNegocio<tbProveedores>
    {
        public IGenericaDatos<tbProveedores> InsProveedoresDatos { get; }
        //inyeccion de proveedres para ir a datos
        public BProveedores(IGenericaDatos<tbProveedores> _insProveedoresDatos)
        {
            InsProveedoresDatos = _insProveedoresDatos;
        }

  

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
            try
            {
                return InsProveedoresDatos.obtenerTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }            
       
        }
    }
}
