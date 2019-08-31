using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BDCore.Models;
using static BDCore.Models.Modelo;

namespace BDCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var db = new AlumnoContext();
            db.Add(new Datos { NUA = "203635", inscripcion = 5, nombre = "Omar Jair Purata Funes", primerApellido = "Purata", segundoApellido = "Funes"});
            db.SaveChanges();
            return View();
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
