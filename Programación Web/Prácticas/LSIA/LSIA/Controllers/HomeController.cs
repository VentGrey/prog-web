using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LSIA.Models;

namespace LSIA.Controllers
{
    public class HomeController : Controller
    {
        static LSIAContext db = new LSIAContext();
        public IActionResult Index()
        {
            Alumnos alumno = new Alumnos();

            alumno.Alumnoid = 1;
            alumno.Nua = "203635";
            alumno.Nombre = "Omar";
            alumno.PrimerApellido = "Purata";
            alumno.Edad = 21;

            // Agregando un registro manualmente
            db.Alumnos.Add(alumno);
            db.SaveChanges();

            var alumnos = db.Alumnos.ToList();

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
