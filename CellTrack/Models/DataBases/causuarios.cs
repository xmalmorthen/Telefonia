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
    
    public partial class causuarios
    {
        public causuarios()
        {
            this.reusuariosperfil = new HashSet<reusuariosperfil>();
            this.malocalizations = new HashSet<malocalizations>();
            this.malocalizations1 = new HashSet<malocalizations>();
        }
    
        public int id { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Nombres { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public System.DateTime fIns { get; set; }
        public Nullable<System.DateTime> fAct { get; set; }
        public Nullable<bool> active { get; set; }
    
        public virtual ICollection<reusuariosperfil> reusuariosperfil { get; set; }
        public virtual ICollection<malocalizations> malocalizations { get; set; }
        public virtual ICollection<malocalizations> malocalizations1 { get; set; }
    }
}
