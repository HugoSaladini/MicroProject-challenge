using MicroOndas.Web.Models;
using MicroOndas.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Adicione serviços se necessário (ex: Razor)
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

// 🔥 ENDPOINT DE AQUECIMENTO
app.MapPost("/api/aquecer", (AquecimentoRequest request) =>
{
    var service = new AquecimentoService();
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
