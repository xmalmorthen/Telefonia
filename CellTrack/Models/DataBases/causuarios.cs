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
            this.malocalizations = new HashSet<malocalizations>();
            this.malocalizations1 = new HashSet<malocalizations>();
        }
    
        public int id { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Nombres { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public Nullable<int> cantidadLocalizaciones { get; set; }
        public bool active { get; set; }
        public System.DateTime fIns { get; set; }
        public Nullable<System.DateTime> fAct { get; set; }
        public int idGpo { get; set; }
        public bool esSupervisor { get; set; }
        public int idPerfil { get; set; }
        public bool isDeleted { get; set; }
    
        public virtual cagrupos cagrupos { get; set; }
        public virtual caperfiles caperfiles { get; set; }
        public virtual ICollection<malocalizations> malocalizations { get; set; }
        public virtual ICollection<malocalizations> malocalizations1 { get; set; }
    }
}
