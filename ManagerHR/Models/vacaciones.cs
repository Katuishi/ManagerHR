//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagerHR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vacaciones
    {
        public int id { get; set; }
        public int idempleado { get; set; }
        public System.DateTime desde { get; set; }
        public System.DateTime hasta { get; set; }
        public int ano { get; set; }
        public string comentarios { get; set; }
    
        public virtual empleado empleado { get; set; }
    }
}
