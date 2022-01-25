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

        public bool eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsProductos guardar(clsProductos entidad)
        {
            //reglas de negocio



            //creo la instancia para pasar los datos a CAPA DE DATOS
            //DProductos proIns = new DProductos();
            return insDProducto.guardar(entidad);



        }

        public clsProductos modificar(clsProductos entidad)
        {
            throw new NotImplementedException();
        }

        public clsProductos obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<clsProductos> obtenerTodos()
        {
            throw new NotImplementedException();
        }

        public void calcular()
        {

        }
    }
}
