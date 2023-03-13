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
    internal class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            //Set the primary key
            builder.HasKey(x => x.Id);
            //Indicate the increase amount of the primary key id 
            builder.Property(x => x.Id).UseIdentityColumn();

            //A product can have only one product feature and the foreign key in the productfeature table is ProductId
            builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature).HasForeignKey<ProductFeature>(x => x.ProductId);
          
        }
    }
}
