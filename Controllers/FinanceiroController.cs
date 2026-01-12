using Microsoft.AspNetCore.Mvc;

namespace FinanceiroBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinanceiroController : ControllerBase
    {
        // Ferramenta para ler o appsettings.json
        private readonly IConfiguration _config;

        // Construtor: Aqui o C# entrega a ferramenta para a gente usar
        public FinanceiroController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("analytics")]
        public IActionResult GetAnalytics()
        {
            var chaveRecebida = Request.Headers["X-Admin-Key"].ToString();
            
            // Lendo a chave que você salvou no arquivo JSON
            var chaveCorreta = _config["SecuritySettings:ApiKey"];

            if (chaveRecebida != chaveCorreta)
            {
                return Unauthorized(new { mensagem = "Acesso Negado!" });
            }

            // DADOS DOS GRÁFICOS (Suas bolinhas coloridas)
            var fluxoCaixa = new[] {
                new { dia = "Seg", valor = 1200 },
                new { dia = "Ter", valor = 1800 },
                new { dia = "Qua", valor = 1400 },
                new { dia = "Qui", valor = 3200 },
                new { dia = "Sex", valor = 2900 },
                new { dia = "Sab", valor = 9000 },
                new { dia = "Don", valor = 4100 }
            };

            var distribuicaoGastos = new[] {
                new { categoria = "Aluguel", valor = 3000 },
                new { categoria = "Cloud Azure", valor = 1500 },
                new { categoria = "Salários", valor = 5000 },
                new { categoria = "Marketing", valor = 2000 }
            };

            return Ok(new { fluxo = fluxoCaixa, gastos = distribuicaoGastos });
        }
    }
}