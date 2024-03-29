﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripLog2.Models.DataAccess;

#nullable disable

namespace Chapter_8.Migrations
{
    [DbContext(typeof(TripLog2Context))]
    [Migration("20230406205924_AddedAccomodations")]
    partial class AddedAccomodations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TripLog2.Models.DomainModels.Accomodation", b =>
                {
                    b.Property<int>("AccomodationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccomodationId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccomodationId");

                    b.ToTable("Accomodation");
                });

            modelBuilder.Entity("TripLog2.Models.DomainModels.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinationId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("TripLog2.Models.DomainModels.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TripId"));

                    b.Property<int>("AccomodationId")
                        .HasColumnType("int");

                    b.Property<string>("Activity1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Activity2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Activity3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("TripId");

                    b.HasIndex("AccomodationId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TripLog2.Models.DomainModels.Trip", b =>
                {
                    b.HasOne("TripLog2.Models.DomainModels.Accomodation", "Accomodation")
                        .WithMany("Trips")
                        .HasForeignKey("AccomodationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TripLog2.Models.DomainModels.Destination", "Destination")
                        .WithMany("Trips")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Accomodation");

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("TripLog2.Models.DomainModels.Accomodation", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("TripLog2.Models.DomainModels.Destination", b =>
                {
                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
