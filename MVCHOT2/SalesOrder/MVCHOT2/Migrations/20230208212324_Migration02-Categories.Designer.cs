﻿// <auto-generated />
using System;
using MVCHOT2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCHOT2.Migrations
{
    [DbContext(typeof(SalesOrderContext))]
    [Migration("20230208212324_Migration02-Categories")]
    partial class Migration02Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCHOT2.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "A",
                            Name = "Accessories"
                        },
                        new
                        {
                            CategoryId = "C",
                            Name = "Components"
                        });
                });

            modelBuilder.Entity("MVCHOT2.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = "C",
                            LongDescription = "",
                            Name = "AeroFlo ATB Wheels",
                            Price = 189.00m,
                            Quantity = 40,
                            ShortDescription = ""
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = "A",
                            LongDescription = "",
                            Name = "Clear Shade 85-T Glasses",
                            Price = 45.00m,
                            Quantity = 14,
                            ShortDescription = ""
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = "C",
                            LongDescription = "",
                            Name = "Cosmic Elite Road Warrior Wheels",
                            Price = 165.00m,
                            Quantity = 22,
                            ShortDescription = ""
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = "A",
                            LongDescription = "",
                            Name = "Cycle-Doc Pro Repair Stand",
                            Price = 166.00m,
                            Quantity = 12,
                            ShortDescription = ""
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = "A",
                            LongDescription = "",
                            Name = "Dog Ear Aero-Flow Floor Pump",
                            Price = 55.00m,
                            Quantity = 25,
                            ShortDescription = ""
                        });
                });

            modelBuilder.Entity("MVCHOT2.Models.Product", b =>
                {
                    b.HasOne("MVCHOT2.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
