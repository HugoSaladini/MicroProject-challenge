using MicroOndas.Domain.Services;
using MicroOndas.Web.Models;
using MicroOndas.Web.Services;
using MicroOndas.Domain;

var builder = WebApplication.CreateBuilder(args);

// Adicione serviços se necessário (ex: Razor)
builder.Services.AddRazorPages();
builder.Services.AddControllers(); // <-- Adiciona os controllers
builder.Services.AddScoped<ProgramasAquecimentoService>();
builder.Services.AddSingleton<ProgramasAquecimentoService>();
builder.Services.AddSingleton<ProgramaCustAquecimentoService>();


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapControllers(); // <-- Mapeia os endpoints dos controllers

// ENDPOINT DE AQUECIMENTO
app.MapPost("/api/aquecer", (AquecimentoRequest request) =>
{
    var service = new AquecimentoService();

    // ❗ Aplica a validação só se NÃO for programa predefinido
    if (!request.UsarProgramaPredefinido && request.TempoEmSegundos > 120)
    {
        return Results.BadRequest(new { error = "O tempo máximo permitido para aquecimento manual é de 120 segundos." });
    }

    try
    {
        var response = service.Aquecer(request.TempoEmSegundos, request.Potencia);
        return Results.Ok(response);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
});

app.Run();
