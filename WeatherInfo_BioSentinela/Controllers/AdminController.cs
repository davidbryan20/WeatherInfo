using Microsoft.AspNetCore.Mvc;
using WeatherInfo_BioSentinela.Models;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            var dados = new DashboardViewModel
            {
                CasosPorBairro = new Dictionary<string, int>
                {
                    { "Centro", 25 },
                    { "Jardim das Flores", 14 },
                    { "Vila Esperança", 38 }
                },
                NiveisDeRisco = new Dictionary<string, string>
                {
                    { "Centro", "Alto" },
                    { "Jardim das Flores", "Moderado" },
                    { "Vila Esperança", "Crítico" }
                },
                AlertasAtivos = new List<string>
                {
                    "Alerta de dengue em Vila Esperança",
                    "Onda de calor prevista para o fim de semana"
                },
                UltimaAtualizacao = DateTime.Now
            };

            return View(dados);
        }
    }
}