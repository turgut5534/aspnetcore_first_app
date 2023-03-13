using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product 
                { 
                    Id = 1, 
                    CategoryId = 1,
                    Name = "Asus ROG" ,
                    Price = 25000,
                    Stock = 100,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Name = "Samsung 4K TV",
                    Price = 35000,
                    Stock = 50,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Samsung M30S",
                    Price = 5000,
                    Stock = 600,
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}
