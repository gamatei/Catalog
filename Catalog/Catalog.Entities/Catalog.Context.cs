﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Catalog.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CatalogProjectEntities : DbContext
    {
        public CatalogProjectEntities()
            : base("name=CatalogProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Absenta> Absentas { get; set; }
        public virtual DbSet<Clasa> Clasas { get; set; }
        public virtual DbSet<Elev> Elevs { get; set; }
        public virtual DbSet<Functie> Functies { get; set; }
        public virtual DbSet<Materie> Materies { get; set; }
        public virtual DbSet<MaterieClasa> MaterieClasas { get; set; }
        public virtual DbSet<Nota> Notas { get; set; }
        public virtual DbSet<Profesor> Profesors { get; set; }
        public virtual DbSet<Utilizator> Utilizators { get; set; }
        public virtual DbSet<UtilizatorAsteptare> UtilizatorAsteptares { get; set; }
    }
}