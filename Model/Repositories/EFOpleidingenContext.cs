using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Model.Repositories
{
    public class EFOpleidingenContext : DbContext
    {

        public static IConfigurationRoot configuration;

        public DbSet<Campus> Campussen { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Land> Landen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            var connectionString = configuration.GetConnectionString("efopleidingen");

            if (connectionString != null)
            {
                optionsBuilder.UseSqlServer(
                    connectionString,
                    options => options.MaxBatchSize(150));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Docent
            modelBuilder.Entity<Docent>()
                .ToTable("Docenten");
            modelBuilder.Entity<Docent>()
                .HasKey(c => c.DocentId);
            modelBuilder.Entity<Docent>()
                .Property(b => b.DocentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Docent>()
                .Property(b => b.Voornaam)
                .IsRequired()
                .HasMaxLength(20);
            modelBuilder.Entity<Docent>()
                .Property(b => b.Familienaam)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Docent>()
                .Property(b => b.Wedde)
                .HasColumnName("Maandwedde")
                .HasColumnType("decimal(18, 4)"); 
            modelBuilder.Entity<Docent>()
                .Property(b => b.InDienst)
                .HasColumnType("date"); 
            modelBuilder.Entity<Docent>()
                .HasOne(b => b.Campus)
                .WithMany(c => c.Docenten)
                .HasForeignKey(b => b.CampusId); 
            modelBuilder.Entity<Docent>()
                .HasOne(b => b.Land)
                .WithMany(c => c.Docenten)
                .HasForeignKey(b => b.LandCode);

            //Campus
            modelBuilder.Entity<Campus>()
                .ToTable("Campussen");
            modelBuilder.Entity<Campus>()
                .HasKey(c => c.CampusId); 
            modelBuilder.Entity<Campus>()
                .Property(b => b.CampusId)
                .ValueGeneratedOnAdd(); 
            modelBuilder.Entity<Campus>()
                .Property(b => b.Naam)
                .HasColumnName("CampusNaam")
                .IsRequired(); 
            modelBuilder.Entity<Campus>().Property(b => b.Gemeente)
                .IsRequired()
                .HasMaxLength(50); 
            modelBuilder.Entity<Campus>()
                .Ignore(c => c.Commentaar);

            //Land
            modelBuilder.Entity<Land>()
                .ToTable("Landen"); 
            modelBuilder.Entity<Land>()
                .HasKey(c => c.LandCode); 
            modelBuilder.Entity<Land>()
                .Property(b => b.LandCode)
                .ValueGeneratedNever();
        }
    }
}
