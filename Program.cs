var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona o suporte para os Controllers (Bolinhas de lógica)
builder.Services.AddControllers();

// 2. Adiciona o gerador do Swagger (O "Cardápio" da nossa API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 3. Ativa a interface visual (Swagger) apenas quando estivermos estudando/desenvolvendo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Aqui é onde a mágica da página visual acontece
}

app.UseAuthorization();
app.MapControllers();

app.Run();