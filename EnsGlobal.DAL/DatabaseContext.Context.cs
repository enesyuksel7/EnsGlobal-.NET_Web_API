﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnsGlobal.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OtoGaleriDBEntities : DbContext
    {
        public OtoGaleriDBEntities()
            : base("name=OtoGaleriDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arabalar> Arabalar { get; set; }
        public virtual DbSet<MasterAdmin> MasterAdmin { get; set; }
        public virtual DbSet<MasterLog> MasterLog { get; set; }
        public virtual DbSet<Satislar> Satislar { get; set; }
        public virtual DbSet<Sigortalar> Sigortalar { get; set; }
        public virtual DbSet<SubeAbonelik> SubeAbonelik { get; set; }
        public virtual DbSet<SubeAdmin> SubeAdmin { get; set; }
        public virtual DbSet<SubeLog> SubeLog { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
