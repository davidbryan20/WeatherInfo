using Microsoft.AspNetCore.Mvc;
using WeatherInfo_BioSentinela.Models;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class AlertasController : Controller
    {
        public IActionResult Index()
        {
            var alertas = new List<Alerta>
            {
                new Alerta
                {
                    Titulo = "Atenção! Aumento de casos de dengue",
                    Descricao = "Foram identificados focos em bairros da zona leste.",
                    Recomendacoes = new List<string> { "Use repelente", "Elimine água parada", "Evite áreas com mato" }
                },
                new Alerta
                {
                    Titulo = "Clima quente e seco – risco de desidratação",
                    Descricao = "Temperaturas acima de 35°C previstas para os próximos dias.",
                    Recomendacoes = new List<string> { "Beba bastante água", "Evite exposição ao sol", "Use roupas leves" }
                }
            };

            return View(alertas);
        }
    }
}
