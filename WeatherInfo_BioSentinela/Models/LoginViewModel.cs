using System.ComponentModel.DataAnnotations;

namespace WeatherInfo_BioSentinela.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "CPF ou Email")]
        public string EmailOuCpf { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Tipo de Usuário")]
        public string TipoUsuario { get; set; }
    }
}