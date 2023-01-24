﻿// <auto-generated />
using System;
using Demo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo.Migrations
{
    [DbContext(typeof(Proiect2Context))]
    partial class Proiect2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo.Models.Categorie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("Demo.Models.Producator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DataVenirii")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeProducator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Producator");
                });

            modelBuilder.Entity("Demo.Models.Produse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cantitate")
                        .HasColumnType("int");

                    b.Property<int>("DataExpirare")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Fabrica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProducatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReducereId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProducatorId");

                    b.HasIndex("ReducereId")
                        .IsUnique()
                        .HasFilter("[ReducereId] IS NOT NULL");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("Demo.Models.ProduseInCategorie", b =>
                {
                    b.Property<Guid>("ProduseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategorieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProduseId", "CategorieId");

                    b.HasIndex("CategorieId");

                    b.ToTable("ProduseInCategorie");
                });

            modelBuilder.Entity("Demo.Models.Reducere", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<double>("Valoare")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Reducere");
                });

            modelBuilder.Entity("Demo.Models.Produse", b =>
                {
                    b.HasOne("Demo.Models.Producator", "Producator")
                        .WithMany("Produse")
                        .HasForeignKey("ProducatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo.Models.Reducere", "Reducere")
                        .WithOne("Produse")
                        .HasForeignKey("Demo.Models.Produse", "ReducereId");

                    b.Navigation("Producator");

                    b.Navigation("Reducere");
                });

            modelBuilder.Entity("Demo.Models.ProduseInCategorie", b =>
                {
                    b.HasOne("Demo.Models.Categorie", "Categorie")
                        .WithMany("ProduseInCategorie")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo.Models.Produse", "Produse")
                        .WithMany("ProduseInCategorie")
                        .HasForeignKey("ProduseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");

                    b.Navigation("Produse");
                });

            modelBuilder.Entity("Demo.Models.Categorie", b =>
                {
                    b.Navigation("ProduseInCategorie");
                });

            modelBuilder.Entity("Demo.Models.Producator", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("Demo.Models.Produse", b =>
                {
                    b.Navigation("ProduseInCategorie");
                });

            modelBuilder.Entity("Demo.Models.Reducere", b =>
                {
                    b.Navigation("Produse")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
