﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderService
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class MMDatabaseEntities : DbContext
    {
        public MMDatabaseEntities()
            : base("name=MMDatabaseEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Order> Orders { get; set; }
    }
}
