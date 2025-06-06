using Microsoft.AspNetCore.Mvc;
using WeatherInfo_BioSentinela.Models;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class SaudeController : Controller
    {
        private static List<Autoavaliacao> Historico = new();

        public IActionResult Index()
        {
            return View(Historico);
        }

        [HttpPost]
        public IActionResult Index(string sintomas)
        {
            var avaliacao = new Autoavaliacao
            {
                Data = DateTime.Now,
                Sintomas = sintomas
            };

            Historico.Add(avaliacao);
            ViewBag.Mensagem = "Autoavaliação registrada com sucesso!";

            return View(Historico);
        }
    }
}