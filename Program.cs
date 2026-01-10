var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

// Esse comando libera o acesso para o navegador
app.UseRouting();
app.MapControllers();

app.Run();