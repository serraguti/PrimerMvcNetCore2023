using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        //TENDREMOS UNA VISTA QUE RECIBIRA LOS DATOS 
        //MEDIANTE GET
        public IActionResult SumarNumerosGet(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["RESULTADO"] = "La suma de " + numero1
                + " + " + numero2 + " es " + suma;
            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["RESULTADO"] = "La suma de "
                + numero1 + " + " + numero2
                + " es " + suma;
            return View();
        }
    }
}
