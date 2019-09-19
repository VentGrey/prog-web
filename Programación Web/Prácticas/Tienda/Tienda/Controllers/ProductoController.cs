using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tienda.Controllers {
    public class ProductoController : Controller {
        // GET: /<controller>/
        public IActionResult Index() {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto
            {
                Nombre = "Mellon Collie And The Infinite Sadness",
                Descripcion = "Uno de los mejores álbums de Rock de los 90's",
                Marca = "TSMP",
                Precio = 104.50f,
                Imagen = "https://www.tinymixtapes.com/sites/default/files/imagecache/Article_Width/news-12-09-smashing-pumpkins.jpg"
            });

            productos.Add(new Producto
            {
                Nombre = "Morningrise",
                Descripcion = "El segundo disco de la banda sueca Opeth",
                Marca = "Candlelight Records",
                Precio = 199.00f,
                Imagen = "https://fanart.tv/detailpreview/fanart/music/c14b4180-dc87-481e-b17a-64e4150f90f6/cdart/morningrise-520e1599a8074.png"
            });

            productos.Add(new Producto
            {
                Nombre = "The Fall of Hearts",
                Descripcion = "El último álbum de la banda Katatonia",
                Marca = "Nuclear Blast Records",
                Precio = 220.50f,
                Imagen = "https://www.theaudiodb.com/images/media/album/cdart/wrsrrv1471033498.png"
            });

            productos.Add(new Producto
            {
                Nombre = "Three Cheers For Sweet Revenge",
                Descripcion = "El 2do álbum más exitoso de la banda MCR",
                Marca = "Reprise Records",
                Precio = 299.00f,
                Imagen = "https://fanart.tv/fanart/music/c07f0676-9143-4217-8a9f-4c26bd636f13/cdart/three-cheers-for-sweet-revenge-4e7568a093667.png"
            });

            productos.Add(new Producto
            {
                Nombre = "The Court Of The Crimson King",
                Descripcion = "El álbum más popular de la banda King Crimson, Remasterizado",
                Marca = "Old Vinyl",
                Precio = 100.50f,
                Imagen = "https://i.pinimg.com/originals/e3/42/47/e34247b39bc91b6a02ee78ce4ea87d47.png"
            });

            return View("Productos", productos);
        }
    }
}
