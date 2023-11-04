﻿// <auto-generated />
using System;
using Arayeshyar.Backend.Infrastructure.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Arayeshyar.Backend.Infrastructure.Migrations
{
    [DbContext(typeof(ArayeshyarDB))]
    [Migration("20231021180725_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Arayeshyar.Backend.Core.Entities.Barber", b =>
                {
                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MobileNumber");

                    b.ToTable("Barber");
                });

            modelBuilder.Entity("Arayeshyar.Backend.Core.Entities.BarberShopOwner", b =>
                {
                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MobileNumber");

                    b.ToTable("BarberShopOwners");
                });

            modelBuilder.Entity("Arayeshyar.Backend.Core.Entities.Customer", b =>
                {
                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MobileNumber");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Arayeshyar.Backend.Core.Entities.SystemAdmin", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("SystemAdmins");
                });
#pragma warning restore 612, 618
        }
    }
}