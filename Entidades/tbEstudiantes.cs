//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEstudiantes
    {
        public int id { get; set; }
        public string carnet { get; set; }
        public Nullable<int> grupo { get; set; }
        public Nullable<int> idPersona { get; set; }
        public string horario { get; set; }
        public Nullable<bool> estado { get; set; }
    
        public virtual tbPersona tbPersona { get; set; }
    }
}
