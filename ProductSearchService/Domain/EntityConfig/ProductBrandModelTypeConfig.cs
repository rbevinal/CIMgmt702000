using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.ProductSearchService.Domain.EntityConfig
{
    public class ProductBrandModelTypeConfig : IEntityTypeConfiguration<ProductBrandModel>
    {
        public void Configure(EntityTypeBuilder<ProductBrandModel> builder)
        {
            builder.HasKey(col => col.Id);
            
            builder
                .Property(col => col.ModelName)
                .HasMaxLength(100);

            builder
                .Property(col => col.ModelColour)
                .HasMaxLength(50);
            builder
                .Property(col => col.ModelTechSpec)
                .HasMaxLength(1000);
            builder
                .Property(col => col.ModelInStock)
                .HasMaxLength(50);
            builder
                .Property(col => col.Location)
                .HasMaxLength(50);

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
        /*
         ModelID int NOT NULL,
	ProductBrandID int, 
        ModelNumber int,
	ModelNumber int NOT NULL,
    ModelName varchar(100),	
	ModelColour varchar(50),
	ModelTechSpec varchar(1000),
	ModelMake varchar(50),
	ModelInStock int,
	CreatedBy varchar(100),
	CreatedOn Datetime,
    ModifiedBy varchar(100),
	ModifiedOn Datetime,
    PRIMARY KEY(ModelID),  
	CONSTRAINT FK_ProductBrandModel FOREIGN KEY(ProductBrandID)

    REFERENCES ProductBrand(ProductBrandID)
         */
    }
}
