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
    
    public partial class reperfilroles
    {
        public int id { get; set; }
        public int idPerfil { get; set; }
        public int idRol { get; set; }
        public System.DateTime fIns { get; set; }
    
        public virtual caperfiles caperfiles { get; set; }
        public virtual caroles caroles { get; set; }
    }
}