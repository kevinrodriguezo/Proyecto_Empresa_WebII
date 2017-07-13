using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proyectoWebII_empresa_asp.net.Models
{
    public class proyectoWebII_empresa_aspnetContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public proyectoWebII_empresa_aspnetContext() : base("name=proyectoWebII_empresa_aspnetContext")
        {
        }

        public System.Data.Entity.DbSet<proyectoWebII_empresa_asp.net.Models.usuario> usuarios { get; set; }

        public System.Data.Entity.DbSet<proyectoWebII_empresa_asp.net.Models.Cliente> Clientes { get; set; }
    }
}
