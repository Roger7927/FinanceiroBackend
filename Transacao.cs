namespace FinanceiroBackend;

public class Transacao
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public double Valor { get; set; }
}