//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CellTrack.Models.DataBases
{
    using System;
    using System.Collections.Generic;
    
    public partial class caroles
    {
        public caroles()
        {
            this.reperfilroles = new HashSet<reperfilroles>();
        }
    
        public int id { get; set; }
        public string rol { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fIns { get; set; }
        public Nullable<System.DateTime> fAct { get; set; }
        public bool activo { get; set; }
        public bool isDeleted { get; set; }
        public string tag { get; set; }
    
        public virtual ICollection<reperfilroles> reperfilroles { get; set; }
    }
}
