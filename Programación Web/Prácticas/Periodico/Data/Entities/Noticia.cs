using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Periodico.Data.Entities
{
    public class Noticia
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Título")]
        [MinLength(5,ErrorMessage ="El título debe de ser mayor a 5 carácteres")]
        public string Titulo { get; set; }
        [Required]
        public string Contenido { get; set; }
        [Required]
        [Display(Name ="Ubicación")]
        public string Ubicacion { get; set; }
        [Display(Name = "Categoría")]
        [Required]
        public Categoria categoria { get; set; }
    }
}
