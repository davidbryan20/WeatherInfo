using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class MapaController : Controller
    {
        private static readonly Dictionary<string, (double lat, double lon)> EstadoCapitais = new Dictionary<string, (double, double)>
        {
            {"SP", (-23.5505, -46.6333)}, // São Paulo
            {"RJ", (-22.9068, -43.1729)}, // Rio de Janeiro
            {"MG", (-19.9208, -43.9378)}, // Belo Horizonte
            {"RS", (-30.0346, -51.2177)}, // Porto Alegre
            // Adicione mais estados se quiser
        };

        public IActionResult Index()
        {
            ViewBag.Estados = EstadoCapitais.Keys;
            return View();
        }
    }
}