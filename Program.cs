var builder = WebApplication.CreateBuilder(args);

// 1. CONFIGURAÇÃO DO CORS (Permite a conversa com o GitHub)
builder.Services.AddCors(options =>
{
    options.AddPolicy("LiberarGeral", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

// 2. ATIVAÇÃO (Deve vir antes do MapControllers)
app.UseCors("LiberarGeral");

app.UseAuthorization();

app.MapControllers();

app.Run();