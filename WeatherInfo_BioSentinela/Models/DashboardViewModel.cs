namespace WeatherInfo_BioSentinela.Models
{
    public class DashboardViewModel
    {
        public Dictionary<string, int> CasosPorBairro { get; set; }
        public Dictionary<string, string> NiveisDeRisco { get; set; }
        public List<string> AlertasAtivos { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
