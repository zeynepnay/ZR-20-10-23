﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShop.Data.Concrete.Contexts;

#nullable disable

namespace MiniShop.Data.Migrations
{
    [DbContext(typeof(MiniShopDbContext))]
    partial class MiniShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("MiniShop.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6762),
                            Description = "TV kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6773),
                            Name = "Televizyon",
                            Url = "televizyon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6776),
                            Description = "Bilgisayar kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6777),
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6778),
                            Description = "Elektronik Eşya kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6778),
                            Name = "Elektronik Eşya",
                            Url = "elektronik-esya"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6779),
                            Description = "Beyaz Eşya kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6780),
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6780),
                            Description = "Telefon kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 947, DateTimeKind.Local).AddTicks(6781),
                            Name = "Telefon",
                            Url = "telefon"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1362),
                            ImageUrl = "1.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1367),
                            Name = "IPhone 14",
                            Price = 59000m,
                            Properties = "Harika bir telefon",
                            Url = "iphone-14"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1372),
                            ImageUrl = "2.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1372),
                            Name = "IPhone 14 Pro",
                            Price = 69000m,
                            Properties = "Bu da harika bir telefon",
                            Url = "iphone-14-pro"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1374),
                            ImageUrl = "3.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1374),
                            Name = "Samsung S23",
                            Price = 49000m,
                            Properties = "İdare eder",
                            Url = "samsung-s23"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1375),
                            ImageUrl = "4.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1376),
                            Name = "Xaomi Note 4",
                            Price = 39000m,
                            Properties = "Harika bir telefon",
                            Url = "xaomi-note-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1377),
                            ImageUrl = "5.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1377),
                            Name = "MacBook Air M2",
                            Price = 52000m,
                            Properties = "M2nin gücü",
                            Url = "macbook-air-m2"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1378),
                            ImageUrl = "6.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1379),
                            Name = "MacBook Pro M3",
                            Price = 79000m,
                            Properties = "16 Gb ram",
                            Url = "macbook-pro-m3"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1380),
                            ImageUrl = "7.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1380),
                            Name = "Vestel Çamaşır Makinesi X65",
                            Price = 19000m,
                            Properties = "Akıllı makine",
                            Url = "vestel-camasir-makinesi-x65"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1382),
                            ImageUrl = "8.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1382),
                            Name = "Arçelik Çamaşır Makinesi A-4",
                            Price = 21000m,
                            Properties = "Süper hızlı makine",
                            Url = "arcelik-camasir-makinesi-a-4"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1383),
                            ImageUrl = "9.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1383),
                            Name = "Hoop Dijital Radyo X96",
                            Price = 1250m,
                            Properties = "Klasik radyo keyfi",
                            Url = "hoop-dijital-radyo-x96"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1385),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 16, 21, 47, 3, 948, DateTimeKind.Local).AddTicks(1385),
                            Name = "Xaomi Dijital Baskül",
                            Price = 2100m,
                            Properties = "Kilonuzu kontrol edin",
                            Url = "xaomi-dijital-baskul"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategories", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 3,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 9
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 11
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 11
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 11
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ProductCategory", b =>
                {
                    b.HasOne("MiniShop.Entity.Concrete.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShop.Entity.Concrete.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
