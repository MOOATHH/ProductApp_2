using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProductApp_Test.Data.Entities;
using ProductApp_Test.Migrations;

namespace ProductApp_Test.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("CodeProductConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductContext, Configuration>());
        }

        public DbSet<Product> Products { get; set; }
    }
}