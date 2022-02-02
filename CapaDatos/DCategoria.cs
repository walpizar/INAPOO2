using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class DCategoria : IGenericaDatos<tbCategorias>
    {
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
                using (var context = new Entities())
                {


                    return context.tbCategorias.ToList();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
