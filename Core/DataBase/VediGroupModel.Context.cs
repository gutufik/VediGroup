﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VediGroupEntities : DbContext
    {
        public VediGroupEntities()
            : base("name=VediGroupEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Tourist> Tourists { get; set; }
        public virtual DbSet<TouristTour> TouristTours { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VisaAvailability> VisaAvailabilities { get; set; }
    }
}
