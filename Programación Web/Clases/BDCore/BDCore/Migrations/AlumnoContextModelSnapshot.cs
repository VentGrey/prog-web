﻿// <auto-generated />
using BDCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BDCore.Migrations
{
    [DbContext(typeof(Modelo.AlumnoContext))]
    partial class AlumnoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BDCore.Models.Modelo+Datos", b =>
                {
                    b.Property<int>("DatosId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NUA");

                    b.Property<int>("inscripcion");

                    b.Property<string>("nombre");

                    b.Property<string>("primerApellido");

                    b.Property<string>("segundoApellido");

                    b.HasKey("DatosId");

                    b.ToTable("datos");
                });
#pragma warning restore 612, 618
        }
    }
}
