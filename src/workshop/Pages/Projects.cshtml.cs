using Microsoft.AspNetCore.Mvc.RazorPages;

namespace workshop.Pages;

public class ProjectsModel : PageModel
{
    public List<ProjectCard> Projects { get; } = new();

    public void OnGet()
    {
        Projects.AddRange(new[]
        {
            new ProjectCard
            {
                Name = "Plataforma de contratos digitais",
                Description = "Automacao do fluxo comercial com assinaturas, alertas e trilha de auditoria.",
                Client = "NorteLog",
                Year = 2025,
                Status = "Em producao",
                StatusCss = "em-producao",
                Technologies = new List<string> { ".NET 8", "Razor Pages", "PostgreSQL", "Docker" }
            },
            new ProjectCard
            {
                Name = "Portal B2B de compras",
                Description = "Nova experiencia para distribuidores com cotacao rapida e catalogo inteligente.",
                Client = "Vitta Supply",
                Year = 2024,
                Status = "Em evolucao",
                StatusCss = "em-evolucao",
                Technologies = new List<string> { "React", ".NET API", "Redis", "Kubernetes" }
            },
            new ProjectCard
            {
                Name = "Central de suporte omnichannel",
                Description = "Unificacao de atendimento com SLAs e visao unica do cliente corporativo.",
                Client = "Aurora Telecom",
                Year = 2024,
                Status = "Entregue",
                StatusCss = "entregue",
                Technologies = new List<string> { "Next.js", ".NET 8", "RabbitMQ", "Grafana" }
            },
            new ProjectCard
            {
                Name = "Integracao de cadeia logistica",
                Description = "Orquestracao de eventos e integrações com parceiros de transporte.",
                Client = "MiraFoods",
                Year = 2023,
                Status = "Entregue",
                StatusCss = "entregue",
                Technologies = new List<string> { "gRPC", "Kafka", ".NET Worker", "Elastic" }
            },
            new ProjectCard
            {
                Name = "Sistema de precificacao dinamica",
                Description = "Regras comerciais personalizadas com governanca e simulacoes.",
                Client = "Optimus Energia",
                Year = 2025,
                Status = "Em producao",
                StatusCss = "em-producao",
                Technologies = new List<string> { "Vue", ".NET 8", "SQL Server", "CI/CD" }
            },
            new ProjectCard
            {
                Name = "Painel de riscos operacionais",
                Description = "Monitoramento de indicadores criticos para equipes de compliance.",
                Client = "Safira Industria",
                Year = 2023,
                Status = "Entregue",
                StatusCss = "entregue",
                Technologies = new List<string> { "Blazor", ".NET 7", "Power BI", "Terraform" }
            }
        });
    }

    public class ProjectCard
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Client { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Status { get; set; } = string.Empty;
        public string StatusCss { get; set; } = string.Empty;
        public List<string> Technologies { get; set; } = new();
    }
}
