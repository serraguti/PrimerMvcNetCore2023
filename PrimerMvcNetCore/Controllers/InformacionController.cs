using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            ViewData["NOMBRE"] = "Alumno";
            ViewBag.Nombre = "Super Alumno";
            ViewData["EDAD"] = 27;
            Persona persona = new Persona();
            persona.Nombre = "Persona Model";
            persona.Email = "modelo@gmail.com";
            persona.Edad = 99;
            return View(persona);
        }

        //VAMOS A RECIBIR DOS PARAMETROS
        public IActionResult VistaControladorGet
            (string app, int? version)
        {
            //IMAGINEMOS QUE LA VERSION ES OPCIONAL
            //A VECES LA RECIBIMOS Y OTRAS NO...
            if (version is not null)
            {
                //ES OPCIONAL
                ViewData["DATOS"] = "Application: " + app 
                    + ", Versión: " + version.GetValueOrDefault();
            }
            else
            {
                ViewData["DATOS"] = "Solo Application: " + app;
            }
            return View();
        }

        public IActionResult VistaControladorPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult 
            VistaControladorPost(string cajanombre
            , string cajaemail, int edad)
        {
            ViewData["DATOS"] = "Nombre: "
                + cajanombre
                + ", Email: "
                + cajaemail
                + ", Edad: "
                + edad;
            return View();
        }
    }
}
