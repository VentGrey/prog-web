using Microsoft.EntityFrameworkCore;
using Periodico.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Periodico.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {               
        }

        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Noticia> noticias{ get; set; }
    }
}
