using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class DProductos : IGenericaDatos<clsProductos>
    {
        //lista para guardar en momoria los productos
        public List<clsProductos> listaProducto { get; set; }


        public DProductos()
        {
            //cuando la capa de datos se instancie, tambien me instancie la lista vacia nueva.
           listaProducto = new List<clsProductos>();
        }


        public bool eliminar(string codigo)
        {

            // borrado fisico
            //var productAntiguo = listaProducto.Where(x => x.codigo == codigo).SingleOrDefault();
            //listaProducto.Remove(productAntiguo);


            //otra manera

            //var productAntiguo = listaProducto.Where(x => x.codigo == codigo).SingleOrDefault();
            //listaProducto.Remove(productAntiguo);

            //productAntiguo.estado = false;
            //listaProducto.Add(productAntiguo);



            //borrado logico
            listaProducto.Where(x => x.codigo == codigo).SingleOrDefault().estado = false;


            return true;

        }

        public clsProductos guardar(clsProductos entidad)
        {
            listaProducto.Add(entidad);
            return entidad;
        }

        public clsProductos modificar(clsProductos entidad)
        {
            var productAntiguo = listaProducto.Where(x=>x.codigo==entidad.codigo).SingleOrDefault();
            listaProducto.Remove(productAntiguo);
            listaProducto.Add(entidad);
            return entidad;


        }

        public clsProductos obtenerPorId(string _codigo)
        {
            //lambda
           return listaProducto.Where(x => x.codigo == _codigo).SingleOrDefault();

        }

        public IEnumerable<clsProductos> obtenerTodos()
        {
            return listaProducto.Where(x=>x.estado==true).ToList();
        }
    }
}
