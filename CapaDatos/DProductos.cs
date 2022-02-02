using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

                var prod = obtenerPorId(codigo); //obtengo de la base
                prod.estado = false;//eliminado logico

                using (var context = new Entities())
                {

                    context.Entry<tbProductos>(prod).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
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
            try
            {
                using (var context = new Entities())
                {

                    context.Entry<tbProductos>(entidad).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return entidad;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


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
