using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsProductos
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public decimal precioCosto { get; set; }
        public decimal utilidad { get; set; }
        public int impuesto { get; set; }
        public decimal precioVenta { get; set; }
        public string categoria { get; set; }
        public string proveedor { get; set; }
        public bool estado { get; set; }
    }
}
