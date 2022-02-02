using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class BCategoria : IGenericaNegocio<tbCategorias>
    {
        public IGenericaDatos<tbCategorias> InsCategorias { get; }

        //inyeccion de categorias para para ir a datos
        public BCategoria(IGenericaDatos<tbCategorias> _insCategorias)
        {
            InsCategorias = _insCategorias;
        }

   

        public bool eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public tbCategorias guardar(tbCategorias entidad)
        {
            throw new NotImplementedException();
        }

        public tbCategorias modificar(tbCategorias entidad)
        {
            throw new NotImplementedException();
        }

        public tbCategorias obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbCategorias> obtenerTodos()
        {
            try
            {
                return InsCategorias.obtenerTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
