using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Set the primary key
            builder.HasKey(x => x.Id);
            //Indicate the increase amount of the primary key id 
            builder.Property(x => x.Id).UseIdentityColumn();
            //Indicate that name property is required and max length is 50
            builder.Property(x=> x.Name).IsRequired().HasMaxLength(50);
            //The table's name is category
            builder.ToTable("Category");
        }
    }
}
