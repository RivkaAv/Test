﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DietEntities : DbContext
    {
        public DietEntities()
            : base("name=DietEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<WeightData> WeightDatas { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
    }
}
