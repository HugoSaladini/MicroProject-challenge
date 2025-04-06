using Microsoft.AspNetCore.Mvc;
using System;

namespace SeuProjeto.Controllers
{
    [ApiController]
    [Route("api/aquecer")] // <-- Rota da API
    public class AquecimentoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] AquecimentoRequest request)
        {
            if (request == null || request.Tempo < 1 || request.Tempo > 120)
                return BadRequest("Tempo inválido. Deve estar entre 1 e 120 segundos.");

            int potencia = request.Potencia ?? 10;

            string resultado = new string('.', potencia);

            return Ok(new
            {
                Mensagem = $"Aquecendo por {request.Tempo} segundos com potência {potencia}.",
                Resultado = resultado
            });
        }
    }

    public class AquecimentoRequest
    {
        public int Tempo { get; set; }
        public int? Potencia { get; set; }
    }
}
