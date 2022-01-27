using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class BProductos : IGenericaNegocio<clsProductos>
    {
        public IGenericaDatos<clsProductos> insDProducto { get; set; }
        public BProductos(IGenericaDatos<clsProductos> _insBProducto)
        {
            this.insDProducto = _insBProducto;
        }

        public bool eliminar(string codigo)
        {

            //reglas de negocio
            return insDProducto.eliminar(codigo);
           
        }

        public clsProductos guardar(clsProductos entidad)
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
                return null;
            }
      
         



        }

        public clsProductos modificar(clsProductos entidad)
        {
            //regla de negocio
            return insDProducto.modificar(entidad);
        }

        public clsProductos obtenerPorId(string codigo)
        {
            return insDProducto.obtenerPorId(codigo);
        }

        public IEnumerable<clsProductos> obtenerTodos()
        {
            return insDProducto.obtenerTodos();
        }

        public void calcular()
        {

        }
    }
}
