﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace User_Registration_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SleepLogAppEntities : DbContext
    {
        public SleepLogAppEntities()
            : base("name=SleepLogAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sleep> Sleep { get; set; }
        public virtual DbSet<SleepTemporary> SleepTemporary { get; set; }
        public virtual DbSet<User> User { get; set; }

        public System.Data.Entity.DbSet<User_Registration_MVC.Models.UserLogin> UserLogins { get; set; }
    }
}
