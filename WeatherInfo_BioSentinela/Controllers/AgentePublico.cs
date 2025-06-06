using Microsoft.AspNetCore.Mvc;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class AgentePublicoController : Controller
    {
        public IActionResult Painel()
        {
            return View();
        }
    }
}