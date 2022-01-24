using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface IGenericaDatos
    {
        bool guardar(clsProductos producto);
        bool eliminar();
    }
}
