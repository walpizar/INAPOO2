using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class DImpuestos : IGenericaDatos<tbImpuestos>
    {
        public bool eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public tbImpuestos guardar(tbImpuestos entidad)
        {
            throw new NotImplementedException();
        }

        public tbImpuestos modificar(tbImpuestos entidad)
        {
            throw new NotImplementedException();
        }

        public tbImpuestos obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbImpuestos> obtenerTodos()
        {
            try
            {
                using (var context = new Entities())
                {


                    return context.tbImpuestos.ToList();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
