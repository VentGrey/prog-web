using System;

namespace Azure.Models {
    public class Pizza {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ingredientes { get; set; }
        public float Precio { get; set; }

        public string Imagen { get; set; }
    }
}