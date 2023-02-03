using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            ViewData["NOMBRE"] = "Alumno";
            ViewBag.Nombre = "Super Alumno";
            ViewData["EDAD"] = 27;
            return View();
        }
    }
}
