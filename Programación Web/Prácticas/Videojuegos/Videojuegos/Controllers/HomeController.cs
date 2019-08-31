using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Videojuegos.Models;

namespace Videojuegos.Controllers
{
    public class HomeController : Controller
    {
        static VideojuegosContext db = new VideojuegosContext();
        public IActionResult Index()
        {
            Catalogo catalogo = new Catalogo();
            var videojuegos = db.Catalogo.ToList();
            return View(videojuegos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
