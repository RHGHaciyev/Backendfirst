﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackendFinal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class watcherEntities : DbContext
    {
        public watcherEntities()
            : base("name=watcherEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_News_category> C_News_category { get; set; }
        public virtual DbSet<Blog_item> Blog_item { get; set; }
        public virtual DbSet<Blog_item_tofile> Blog_item_tofile { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<content> contents { get; set; }
        public virtual DbSet<exchange> exchanges { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<filled_contents> filled_contents { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<type> types { get; set; }
        public virtual DbSet<User_reg> User_reg { get; set; }
        public virtual DbSet<User_rol> User_rol { get; set; }
        public virtual DbSet<User_Type> User_Type { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
    }
}