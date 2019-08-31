using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LSIA.Models
{
    public partial class LSIAContext : DbContext
    {
        public LSIAContext()
        {
        }

        public LSIAContext(DbContextOptions<LSIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumnos> Alumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=LSIA; User ID=sa; Password=Blazewolf90");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Alumnos>(entity =>
            {
                entity.HasKey(e => e.Alumnoid)
                    .HasName("Alumnos_PK");

                entity.Property(e => e.Alumnoid).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nua)
                    .IsRequired()
                    .HasColumnName("NUA")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .IsUnicode(false);
            });
        }
    }
}
