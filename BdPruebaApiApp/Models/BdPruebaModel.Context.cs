﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BdPruebaApiApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBPRUEBAEntities1 : DbContext
    {
        public DBPRUEBAEntities1()
            : base("name=DBPRUEBAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<usp_SelectProducts_Result> usp_SelectProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectProducts_Result>("usp_SelectProducts");
        }
    }
}
