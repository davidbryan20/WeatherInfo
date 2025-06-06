using Microsoft.AspNetCore.Mvc;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class ReporteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enviar(string tipo, string descricao, string bairro)
        {
            TempData["Mensagem"] = "Reporte enviado com sucesso! Obrigado por colaborar.";
            return RedirectToAction("Index");
        }
    }
}
