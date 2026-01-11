using Microsoft.AspNetCore.Mvc;

namespace FinanceiroBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FinanceiroController : ControllerBase
{
    [HttpGet("analytics")]
    public IActionResult GetAnalytics()
    {
        // Simulando dados que viriam de um Banco de Dados
        var historico = new[] {
            new { Dia = "Seg", Valor = 1200 },
            new { Dia = "Ter", Valor = 1800 },
            new { Dia = "Qua", Valor = 1400 },
            new { Dia = "Qui", Valor = 3200 },
            new { Dia = "Sex", Valor = 2900 },
            new { Dia = "Sab", Valor = 4500 },
            new { Dia = "Dom", Valor = 4100 }
        };

        return Ok(historico); // Retorna a lista organizada
    }
}