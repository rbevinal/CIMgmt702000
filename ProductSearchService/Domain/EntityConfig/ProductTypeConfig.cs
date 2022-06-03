using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.ProductSearchService.Domain.EntityConfig
{
    public class ProductTypeConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(col => col.Id);
            builder.HasMany(col => col.ProductBrands);
            builder
                .Property(col => col.ProductName)
                .HasMaxLength(80);
            builder
                .Property(col => col.ProductNumber)
                .IsRequired();
            builder
                .Property(col => col.CreatedBy)
                .HasMaxLength(100);

            builder
                .Property(col => col.CreatedOn)
                .HasDefaultValueSql("getdate()");

            builder
                .Property(col => col.ModifiedBy)
                .HasMaxLength(100);

            builder
                .Property(col => col.ModifiedOn)
                .HasDefaultValueSql("getdate()");
        }        
    }
}
