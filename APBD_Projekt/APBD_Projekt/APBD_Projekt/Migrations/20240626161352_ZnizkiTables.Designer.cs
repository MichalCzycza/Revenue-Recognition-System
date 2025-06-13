﻿// <auto-generated />
using System;
using APBD_Projekt.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APBD_Projekt.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20240626161352_ZnizkiTables")]
    partial class ZnizkiTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APBD_Projekt.Models.Firma", b =>
                {
                    b.Property<int>("FirmaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FirmaID"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KRS")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NazwaFirmy")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NrTelefonu")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("FirmaID");

                    b.ToTable("Firmy");
                });

            modelBuilder.Entity("APBD_Projekt.Models.KlientFizyczny", b =>
                {
                    b.Property<int>("KlientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KlientID"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NrTelefonu")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PESEL")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("czyUsuniety")
                        .HasColumnType("bit");

                    b.HasKey("KlientID");

                    b.ToTable("KlienciFizyczni");
                });

            modelBuilder.Entity("APBD_Projekt.Models.Oprogramowanie", b =>
                {
                    b.Property<int>("OprogramowanieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OprogramowanieID"));

                    b.Property<double>("Cena")
                        .HasPrecision(10, 2)
                        .HasColumnType("float(10)");

                    b.Property<int>("FirmaID")
                        .HasColumnType("int");

                    b.Property<string>("Kategoria")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("KlientFizycznyID")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Wersja")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OprogramowanieID");

                    b.HasIndex("FirmaID");

                    b.HasIndex("KlientFizycznyID");

                    b.ToTable("Oprogramowania");
                });

            modelBuilder.Entity("APBD_Projekt.Models.Znizka", b =>
                {
                    b.Property<int>("ZnikaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZnikaID"));

                    b.Property<DateTime>("ObowiazujeDo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ObowiazujeOd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Oferta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Wartosc")
                        .HasColumnType("int");

                    b.HasKey("ZnikaID");

                    b.ToTable("Znizka");
                });

            modelBuilder.Entity("OprogramowanieZnizka", b =>
                {
                    b.Property<int>("OprogramowaniaOprogramowanieID")
                        .HasColumnType("int");

                    b.Property<int>("ZnizkiZnikaID")
                        .HasColumnType("int");

                    b.HasKey("OprogramowaniaOprogramowanieID", "ZnizkiZnikaID");

                    b.HasIndex("ZnizkiZnikaID");

                    b.ToTable("OprogramowanieZnizka");
                });

            modelBuilder.Entity("APBD_Projekt.Models.Oprogramowanie", b =>
                {
                    b.HasOne("APBD_Projekt.Models.Firma", "Firma")
                        .WithMany()
                        .HasForeignKey("FirmaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_Projekt.Models.KlientFizyczny", "KlientFizyczny")
                        .WithMany()
                        .HasForeignKey("KlientFizycznyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");

                    b.Navigation("KlientFizyczny");
                });

            modelBuilder.Entity("OprogramowanieZnizka", b =>
                {
                    b.HasOne("APBD_Projekt.Models.Oprogramowanie", null)
                        .WithMany()
                        .HasForeignKey("OprogramowaniaOprogramowanieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_Projekt.Models.Znizka", null)
                        .WithMany()
                        .HasForeignKey("ZnizkiZnikaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
