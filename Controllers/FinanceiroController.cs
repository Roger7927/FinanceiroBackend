using Microsoft.AspNetCore.Mvc;

namespace FinanceiroBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FinanceiroController : ControllerBase
{
    [HttpGet("extrato-completo")]
    public IActionResult Get()
    {
        var lista = new List<Transacao>
        {
            new Transacao { Id = 1, Descricao = "Salário", Valor = 5000 },
            new Transacao { Id = 2, Descricao = "Aluguel", Valor = -1200 },
            new Transacao { Id = 3, Descricao = "Mercado", Valor = -450.50 }
        };

        // Lógica de Negócio (Business Logic): Somando as bolinhas
        double saldoFinal = 0;
        foreach (var t in lista)
        {
            saldoFinal += t.Valor;
        }

        // Retorna um objeto anônimo com a lista e o saldo processado
        return Ok(new { 
            Mensagem = "Relatório Gerado com Sucesso",
            Transacoes = lista, 
            SaldoTotal = saldoFinal 
        });
    }
}