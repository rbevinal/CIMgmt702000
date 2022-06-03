using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.ProductSearchService.Domain.EntityConfig
{
    public class ProductBrandTypeConfig : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.HasKey(col => col.Id);
            builder.HasOne(col => col.Product);
            builder
                .Property(col => col.ProductBrandName)
                .HasMaxLength(80);
           
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
