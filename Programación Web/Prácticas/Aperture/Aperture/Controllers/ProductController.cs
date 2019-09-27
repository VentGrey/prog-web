using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Aperture.Models;

namespace Aperture.Controllers {
    public class ProductController : Controller {
        // GET: /<controller>
        public IActionResult Index() {
            List<Producto> productos2 = new List<Producto>();

            productos2.Add(new Producto {
                Nombre = "Handheld Portal Device",
                Descripcion = "Gracias al dispositivo generador de portales portátil de Aperture Science, lo imposible es fácil",
                Foto = "http://vignette3.wikia.nocookie.net/peridot0/images/5/55/Portal_gun.png/revision/latest?cb=20151125032200"
            });

            productos2.Add(new Producto {
                Nombre = "Torreta Casera",
                Descripcion = "Empacamos las mejores torretas para la seguridad de tu hogar",
                Foto = "https://vignette.wikia.nocookie.net/portal-fan-ideas/images/e/eb/Portal2TurretStandard.png/revision/latest?cb=20150918221136"
            });

            productos2.Add(new Producto {
                Nombre = "GlaD0S",
                Descripcion ="Un asistente personal para toda su fundación, por solo <Inserte precio excesivo>",
                Foto = "https://vignette.wikia.nocookie.net/deathbattlefanon/images/e/e0/GLaDOS.png/revision/latest?cb=20150601221456"
            });

            productos2.Add(new Producto {
                Nombre = "PotaT0S",
                Descripcion = "El mismo asistente personal, pero en versión económica. Solo consume 1.1V",
                Foto = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/4fb8aac1-d7c1-4583-acf0-7a1699336656/d5l4fps-36ec6e4d-d2fe-4304-a750-56e5842a2a80.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzRmYjhhYWMxLWQ3YzEtNDU4My1hY2YwLTdhMTY5OTMzNjY1NlwvZDVsNGZwcy0zNmVjNmU0ZC1kMmZlLTQzMDQtYTc1MC01NmU1ODQyYTJhODAucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.QNlg8J7TyzMCH0WfX8jEENPPMQmqK0fhXBsSST4-Q00"
            });

            return View("Productos", productos2);
        }
    }
}