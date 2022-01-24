using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BProductos : IGenerica
    {
      
        public bool eliminar()
        {
            throw new NotImplementedException();
        }

        public bool guardar(clsProductos producto)
        {

            //reglas de negocio
            DProductos proIns = new DProductos();

           return  proIns.guardar(producto);
            
        }


        private void aumentarSalario()
        {

        }
    }
}
