var builder = WebApplication.CreateBuilder(args);

// --- COPIE ESTA LINHA ABAIXO (Configura a permissão) ---
builder.Services.AddCors(options => options.AddPolicy("LiberarGeral", 
    p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

builder.Services.AddControllers();
var app = builder.Build();

// --- COPIE ESTA LINHA ABAIXO (Ativa a permissão) ---
app.UseCors("LiberarGeral");

app.UseAuthorization();
app.MapControllers();
app.Run();