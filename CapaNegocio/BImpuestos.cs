using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class BImpuestos : IGenericaNegocio<tbImpuestos>
    {
        //inyeccion de impuestos para ir a datos

        public IGenericaDatos<tbImpuestos> InsInpuestosDatos { get; }

        public BImpuestos(IGenericaDatos<tbImpuestos> _insInpuestosDatos)
        {
            InsInpuestosDatos = _insInpuestosDatos;
        }

        

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
                return InsInpuestosDatos.obtenerTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
