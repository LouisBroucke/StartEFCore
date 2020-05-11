﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Repositories;

namespace Model.Migrations
{
    [DbContext(typeof(EFOpleidingenContext))]
    [Migration("20200505101415_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Entities.Campus", b =>
                {
                    b.Property<int>("CampusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gemeente")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Huisnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnName("CampusNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CampusId");

                    b.ToTable("Campussen");
                });

            modelBuilder.Entity("Model.Entities.Docent", b =>
                {
                    b.Property<int>("DocentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CampusId")
                        .HasColumnType("int");

                    b.Property<string>("Familienaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool?>("HeeftRijbewijs")
                        .HasColumnType("bit");

                    b.Property<DateTime>("InDienst")
                        .HasColumnType("date");

                    b.Property<string>("LandCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("Wedde")
                        .HasColumnName("Maandwedde")
                        .HasColumnType("decimal(18, 4)");

                    b.HasKey("DocentId");

                    b.HasIndex("CampusId");

                    b.HasIndex("LandCode");

                    b.ToTable("Docenten");
                });

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Property<string>("LandCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LandCode");

                    b.ToTable("Landen");
                });

            modelBuilder.Entity("Model.Entities.Docent", b =>
                {
                    b.HasOne("Model.Entities.Campus", "Campus")
                        .WithMany("Docenten")
                        .HasForeignKey("CampusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Land", "Land")
                        .WithMany("Docenten")
                        .HasForeignKey("LandCode");
                });
#pragma warning restore 612, 618
        }
    }
}
