using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Videojuegos.Models
{
    public partial class VideojuegosContext : DbContext
    {
        public VideojuegosContext()
        {
        }

        public VideojuegosContext(DbContextOptions<VideojuegosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Catalogo> Catalogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Videojuegos; User ID=sa; Password=Blazewolf90");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Catalogo>(entity =>
            {
                entity.HasKey(e => e.VideojuegoId)
                    .HasName("Catalogo_PK");

                entity.Property(e => e.Imagen).IsRequired();

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Videojuego).IsRequired();
            });
        }
    }
}
