using Microsoft.AspNetCore.Mvc;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class RiscoController : Controller
    {
        public IActionResult Mapa()
        {
            return View();
        }
    }
}