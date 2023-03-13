using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base()
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductFeature> ProductFeature { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature
                {
                    Id = 1,
                    Color = "Red",
                    Height = 100,
                    Width = 200,
                    ProductId = 1
                },
                new ProductFeature 
                {
                Id = 2,
                    Color = "Green",
                    Height = 200,
                    Width = 200,
                    ProductId = 2
                },
              new ProductFeature
              {
                Id = 3,
                    Color = "Blue",
                    Height = 300,
                    Width = 200,
                    ProductId = 3
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
