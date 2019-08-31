using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BDCore.Models {
    public class Modelo {
        public class AlumnoContext : DbContext {
            public DbSet<Datos> datos { get; set; }
            
            protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlServer("Server=localhost; Database=prueba; User Id=sa; Password=Blazewolf90;");

        }

        public class Datos {
            public int DatosId { get; set; }
            public string NUA { get; set; }
            public int inscripcion { get; set; }
            public string nombre { get; set; }
            public string primerApellido { get; set; }
            public string segundoApellido { get; set; }
        }
    }
}