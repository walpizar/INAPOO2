using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class DProductos : IGenericaDatos<tbProductos>
    {
        //lista para guardar en momoria los productos
        public List<tbProductos> listaProducto { get; set; }
 

        public DProductos()
        {
            //cuando la capa de datos se instancie, tambien me instancie la lista vacia nueva.
           listaProducto = new List<tbProductos>();
           
        }


        public bool eliminar(string codigo)
        {
            try
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
            catch (Exception ex)
            {

                throw ex;
            }
           

        }

        public tbProductos guardar(tbProductos entidad)
        {
            try
            {

                using (var context = new Entities())
                {
                    entidad = context.tbProductos.Add(entidad);
                    context.SaveChanges();


                }
                  
                return entidad;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public tbProductos modificar(tbProductos entidad)
        {
            var productAntiguo = listaProducto.Where(x=>x.codigo.Trim()==entidad.codigo.Trim()).SingleOrDefault();
            listaProducto.Remove(productAntiguo);
            listaProducto.Add(entidad);
            return entidad;


        }

        public tbProductos obtenerPorId(string _codigo)
        {

            try
            {
                using (var context = new Entities())
                {
                    return context.tbProductos.Where(x => x.codigo.Trim() == _codigo.Trim()).SingleOrDefault();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            //lambda
            //return listaProducto.Where(x => x.codigo == _codigo).SingleOrDefault();

        }

        public IEnumerable<tbProductos> obtenerTodos()
        {
            try
            {
                using (var context = new Entities())
                {
                    return context.tbProductos.Where(x => x.estado == true).ToList();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
