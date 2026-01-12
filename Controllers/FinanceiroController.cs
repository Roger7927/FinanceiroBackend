using Microsoft.AspNetCore.Mvc; // 1. MANUAL NO TOPO (Sempre na Linha 1)

namespace FinanceiroBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinanceiroController : ControllerBase
    {
        private readonly IConfiguration _config;

        // 2. CONSTRUTOR: Recebe a chave do cofre
        public FinanceiroController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("analytics")]
        public IActionResult GetAnalytics()
        {
            var dataHora = DateTime.Now.ToLongTimeString();
            var chaveRecebida = Request.Headers["X-Admin-Key"].ToString();

            // 3. LOG DE ENTRADA
            Console.WriteLine($"\n[MONITORAMENTO] --- Nova requisição: {dataHora} ---");

            // 4. VERIFICAÇÃO DE SEGURANÇA
            if (chaveRecebida != _config["SecuritySettings:ApiKey"])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ BLOQUEADO: Tentativa de acesso com chave inválida!");
                Console.ResetColor();
                return Unauthorized(new { mensagem = "Acesso Negado!" });
            }

            // 5. LOG DE SUCESSO EM VERDE
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✅ SUCESSO: Chave validada. Liberando as bolinhas de dados...");
            Console.ResetColor();

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