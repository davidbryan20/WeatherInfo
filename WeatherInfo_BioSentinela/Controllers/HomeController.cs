using Microsoft.AspNetCore.Mvc;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Retorna a view com o conte�do inicial e links
        }

        [HttpGet]
        public IActionResult Login()
        {
            // Redireciona para o controlador de login (opcionalmente voc� pode criar aqui direto)
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Error()
        {
            return View(); // Exibe p�gina de erro se necess�rio
        }
    }
}