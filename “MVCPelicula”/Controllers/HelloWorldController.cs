using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace _MVCPelicula_.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "Bienvenido a la aplicación de películas!";
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string nombre, string apellido, int veces = 1)
        {
            string saludoCompleto = $"Saludos {nombre} {apellido}";
            ViewData["SaludoCompleto"] = saludoCompleto;
            ViewData["Veces"] = veces;

            return View();
        }
    }
}
