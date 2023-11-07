﻿// <auto-generated />
using System;
using HB.MvcAppWDB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HB.MvcAppWDB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231107134444_randevu")]
    partial class randevu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HB.MvcAppWDB.Entities.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorler");
                });

            modelBuilder.Entity("HB.MvcAppWDB.Entities.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BasımTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("KitapAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriID");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("HB.MvcAppWDB.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HB.MvcAppWDB.Entities.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MüşteriAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RandevuTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("İşlem")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Randevus");
                });

            modelBuilder.Entity("HB.MvcAppWDB.Entities.Kitap", b =>
                {
                    b.HasOne("HB.MvcAppWDB.Entities.Kategori", "Kategori")
                        .WithMany("Kitaplar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("HB.MvcAppWDB.Entities.Kategori", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
