using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Exceptions;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class BProductos : IGenericaNegocio<tbProductos>
    {
        public IGenericaDatos<tbProductos> insDProducto { get; set; }
        public BProductos(IGenericaDatos<tbProductos> _insBProducto)
        {
            this.insDProducto = _insBProducto;
        }

        public bool eliminar(string codigo)
        {
            try
            {
                //reglas de negocio
                return insDProducto.eliminar(codigo);
            }
            catch (InvalidOperationException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {


            }
          
           
        }

        public tbProductos guardar(tbProductos entidad)
        {
            try
            {
                //reglas de negocio
                //1-validar que no exista atravez del codigo
                var result = obtenerPorId(entidad.codigo);

                //verifico si encontro algo con el codigo enviado
                if (result == null)
                {
                    //creo la instancia para pasar los datos a CAPA DE DATOS
                    //DProductos proIns = new DProductos();
                    return insDProducto.guardar(entidad);

                }
                else
                {
                    if (result.estado) {
                        
                        throw new EntityExistException("Producto");

                    }
                    else
                    {
                        throw new EntityExistDisableException("Producto");
                    }
                    


                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
         



        }

        public tbProductos modificar(tbProductos entidad)
        {
            try
            {
                return insDProducto.modificar(entidad);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //regla de negocio
           
        }

        public tbProductos obtenerPorId(string codigo)
        {
            return insDProducto.obtenerPorId(codigo);
        }

        public IEnumerable<tbProductos> obtenerTodos()
        {
            try
            {
                return insDProducto.obtenerTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }

        public void calcular()
        {

        }
    }
}
