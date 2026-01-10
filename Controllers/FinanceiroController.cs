using Microsoft.AspNetCore.Mvc;

namespace FinanceiroBackend.Controllers;

[ApiController]
[Route("resumo")] // Rota direta para facilitar seu teste
public class FinanceiroController : ControllerBase
{
    private static decimal entradaFixa = 11000.00m;
    private static decimal saidaFixa = 14100.05m;

    [HttpGet]
    public IActionResult GetResumo()
    {
        var saldo = entradaFixa - saidaFixa;
        
        return Ok(new {
            entrada = entradaFixa,
            saida = saidaFixa,
            total = saldo
        });
    }
}