using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Interfaces
{
    public interface IGenericaNegocio<entidad>
    {
        entidad guardar(entidad entidad);

        entidad modificar(entidad entidad);

        IEnumerable<entidad> obtenerTodos();

        entidad obtenerPorId(string id);

        bool eliminar(string id);
    }
}
