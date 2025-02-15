﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20250202102033_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Price = 40000m,
                            ProductName = "Laptop"
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 12000m,
                            ProductName = "Monitor"
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 1000m,
                            ProductName = "Keyboard"
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 500m,
                            ProductName = "Mouse"
                        },
                        new
                        {
                            ProductId = 5,
                            Price = 2000m,
                            ProductName = "Headphone"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
