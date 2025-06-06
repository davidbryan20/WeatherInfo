using Microsoft.AspNetCore.Mvc;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Retorna a view com o conteúdo inicial e links
        }

        [HttpGet]
        public IActionResult Login()
        {
            // Redireciona para o controlador de login (opcionalmente você pode criar aqui direto)
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Error()
        {
            return View(); // Exibe página de erro se necessário
        }
    }
}