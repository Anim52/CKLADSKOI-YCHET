using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lopushok.Models
{
    public class Context : DbContext
    {
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseProduct> WarehouseProducts { get; set; }

        public Context() {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
            //(localdb)\MSSQLLocalDB DESKTOP-HREVK3R
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Lopushok;Database=Lopushok;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
