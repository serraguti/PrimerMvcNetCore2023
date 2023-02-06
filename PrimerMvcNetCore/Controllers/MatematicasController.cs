using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int valor)
        {
            List<int> resultados = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                int operacion = valor * i;
                resultados.Add(operacion);
            }
            return View(resultados);
        }

        public IActionResult TablaMultiplicarCompuesta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarCompuesta(int numero)
        {
            List<FilaTablaMultiplicar> resultados = new List<FilaTablaMultiplicar>();
            for (int i = 1; i <= 10; i++)
            {
                FilaTablaMultiplicar fila = new FilaTablaMultiplicar();
                fila.Operacion = numero + " * " + i;
                fila.Resultado = numero * i;
                resultados.Add(fila);
            }
            return View(resultados);
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            return View(numeros);
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
