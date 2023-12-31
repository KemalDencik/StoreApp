﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Model;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("StoreApp.Model.Product", b =>
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
                            Price = 20000m,
                            ProductName = "Computer"
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 2000m,
                            ProductName = "Keyboard"
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 12000m,
                            ProductName = "Android Watch"
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 22500m,
                            ProductName = "Play Station"
                        },
                        new
                        {
                            ProductId = 5,
                            Price = 20m,
                            ProductName = "Book"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
