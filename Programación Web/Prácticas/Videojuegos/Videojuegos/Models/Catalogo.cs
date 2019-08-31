using System;
using System.Collections.Generic;

namespace Videojuegos.Models
{
    public partial class Catalogo
    {
        public int VideojuegoId { get; set; }
        public string Videojuego { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
    }
}
