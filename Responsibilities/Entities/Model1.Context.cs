﻿ //------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Responsibilities.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ResponsibilitiesEntities : DbContext
    {
        public ResponsibilitiesEntities()
            : base("name=ResponsibilitiesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        internal static object GetContext()
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypesOfWork> TypesOfWorks { get; set; }
        public virtual DbSet<Work> Works { get; set; }
    }
}
