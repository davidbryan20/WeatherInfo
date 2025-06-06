using Microsoft.AspNetCore.Mvc;
using WeatherInfo_BioSentinela.Models;

namespace WeatherInfo_BioSentinela.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Login mockado
            if ((model.EmailOuCpf == "dbryan@ex.com" && model.Senha == "1234" && model.TipoUsuario == "Cidadao"))
            {
                return RedirectToAction("Index", "Home"); // ✅ Agora leva ao menu inicial
            }
            else if ((model.EmailOuCpf == "age@ex.com" && model.Senha == "1234" && model.TipoUsuario == "AgentePublico"))
            {
                return RedirectToAction("Index", "Admin"); // Redireciona ao painel do agente público
            }

            ModelState.AddModelError(string.Empty, "Credenciais inválidas ou tipo de usuário incorreto.");
            return View(model);
        }
    }
}
