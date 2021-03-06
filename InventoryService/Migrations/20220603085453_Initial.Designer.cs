// <auto-generated />
using System;
using CIMgmt702000.InventoryService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIMgmt702000.InventoryService.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20220603085453_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CIMgmt702000.InventoryService.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("ProductName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ProductNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CIMgmt702000.InventoryService.Domain.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<string>("ProductBrandName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("ProductBrandNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductBrand");
                });

            modelBuilder.Entity("CIMgmt702000.InventoryService.Domain.ProductBrandModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModelColour")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ModelInStock")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("ModelMake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ModelNumber")
                        .HasColumnType("int");

                    b.Property<string>("ModelTechSpec")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ProductBrandID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandID");

                    b.ToTable("ProductBrandModel");
                });

            modelBuilder.Entity("CIMgmt702000.InventoryService.Domain.ProductBrand", b =>
                {
                    b.HasOne("CIMgmt702000.InventoryService.Domain.Product", "Product")
                        .WithMany("ProductBrands")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CIMgmt702000.InventoryService.Domain.ProductBrandModel", b =>
                {
                    b.HasOne("CIMgmt702000.InventoryService.Domain.ProductBrand", "ProductBrand")
                        .WithMany("ProductBrandModels")
                        .HasForeignKey("ProductBrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");
                });

            modelBuilder.Entity("CIMgmt702000.InventoryService.Domain.Product", b =>
                {
                    b.Navigation("ProductBrands");
                });

            modelBuilder.Entity("CIMgmt702000.InventoryService.Domain.ProductBrand", b =>
                {
                    b.Navigation("ProductBrandModels");
                });
#pragma warning restore 612, 618
        }
    }
}
