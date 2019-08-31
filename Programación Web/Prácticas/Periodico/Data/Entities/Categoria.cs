using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Periodico.Data.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre de la categoría")]
        [MinLength(5, ErrorMessage = "La categoría debe de ser mayor a 5 carácteres")]
        public string Nombre { get; set; }

        public ICollection<Noticia> noticias { get; set; }
    }
}
