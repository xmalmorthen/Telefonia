﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbgeolocEntities : DbContext
    {
        public dbgeolocEntities()
            : base("name=dbgeolocEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cacarriers> cacarriers { get; set; }
        public DbSet<cagrupos> cagrupos { get; set; }
        public DbSet<caperfiles> caperfiles { get; set; }
        public DbSet<caroles> caroles { get; set; }
        public DbSet<causuarios> causuarios { get; set; }
        public DbSet<desmsrecibidos> desmsrecibidos { get; set; }
        public DbSet<gmapnetcache> gmapnetcache { get; set; }
        public DbSet<mahlr> mahlr { get; set; }
        public DbSet<malocalizations> malocalizations { get; set; }
        public DbSet<mapdu> mapdu { get; set; }
        public DbSet<reperfilroles> reperfilroles { get; set; }
        public DbSet<tbllogs> tbllogs { get; set; }
        public DbSet<vwactivecarriers> vwactivecarriers { get; set; }
        public DbSet<vwusernotifications> vwusernotifications { get; set; }
    }
}
