using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _2_DB_Create_Ornek.Models;

namespace _2_DB_Create_Ornek.AppDbContext
{
    public partial class KisiContext : DbContext
    {
        public KisiContext()
        {
        }

        public KisiContext(DbContextOptions<KisiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kisi> Kisis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=Kisi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>(entity =>
            {
                entity.ToTable("Kisi");

                entity.Property(e => e.KisiId)
                    .ValueGeneratedNever()
                    .HasColumnName("KisiID");

                entity.Property(e => e.Adres).HasMaxLength(500);

                entity.Property(e => e.DogumTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.KisiAd).HasMaxLength(50);

                entity.Property(e => e.KisiSoyad).HasMaxLength(50);

                entity.Property(e => e.Sehir).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
