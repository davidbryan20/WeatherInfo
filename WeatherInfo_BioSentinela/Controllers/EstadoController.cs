using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WeatherInfo_BioSentinela.Models;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class EstadoController : Controller
    {
        private static readonly Dictionary<string, string> EstadoParaCidade = new()
        {
            { "SP", "São Paulo" },
            { "RJ", "Rio de Janeiro" },
            { "MG", "Belo Horizonte" },
            { "RS", "Porto Alegre" }
        };

        private static readonly Dictionary<string, string> RiscosPorClima = new()
        {
            { "Chuva", "Dengue, Leptospirose" },
            { "Ensolarado", "Desidratação, Insolação" },
            { "Nublado", "Gripe, Pneumonia" }
        };

        public IActionResult Index()
        {
            ViewBag.Estados = new SelectList(EstadoParaCidade, "Key", "Key");
            return View();
        }

        [HttpPost]
        public IActionResult Verificar(string estado)
        {
            if (!EstadoParaCidade.ContainsKey(estado))
            {
                ModelState.AddModelError("", "Estado inválido.");
                ViewBag.Estados = new SelectList(EstadoParaCidade, "Key", "Key");
                return View("Index");
            }

            var cidade = EstadoParaCidade[estado];
            var clima = ObterClimaMockado(cidade);
            var temperatura = ObterTemperaturaMockada(cidade);

            var chaveClima = RiscosPorClima.Keys.FirstOrDefault(k => clima.Contains(k, StringComparison.OrdinalIgnoreCase));
            var riscos = chaveClima != null ? RiscosPorClima[chaveClima] : "Sem riscos relevantes";

            var model = new EstadoInfo
            {
                Estado = estado,
                Clima = clima,
                Temperatura = temperatura,
                RiscoDeDoencas = riscos
            };

            ViewBag.Estados = new SelectList(EstadoParaCidade, "Key", "Key", estado);
            return View("Index", model);
        }

        // --- MOCKADOS abaixo ---

        private string ObterClimaMockado(string cidade)
        {
            return cidade switch
            {
                "São Paulo" => "Chuva",
                "Rio de Janeiro" => "Ensolarado",
                "Belo Horizonte" => "Nublado",
                "Porto Alegre" => "Chuva",
                _ => "Indefinido"
            };
        }

        private string ObterTemperaturaMockada(string cidade)
        {
            return cidade switch
            {
                "São Paulo" => "18°C / 23°C",
                "Rio de Janeiro" => "26°C / 33°C",
                "Belo Horizonte" => "20°C / 27°C",
                "Porto Alegre" => "17°C / 22°C",
                _ => "--"
            };
        }
    }
}