using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Set the primary key
            builder.HasKey(x => x.Id);
            //Indicate the increase amount of the primary key id 
            builder.Property(x => x.Id).UseIdentityColumn();
            //Indicate that name property is required and max length is 50
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            //The integer price property can be 20 character. But there can be 2 digit after comma. Total is 20 including after comma
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            //The table's name is category
            builder.ToTable("Products");

            //Category table has many products and the foreign key in the product table is category id
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}
