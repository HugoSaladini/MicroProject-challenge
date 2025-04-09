using MicroOndas.Web.Models;
using Microsoft.AspNetCore.Mvc;
using MicroOndas.Domain.Models;

namespace SeuProjeto.Controllers
{
    [ApiController]
    [Route("api/aquecer")]
    public class AquecimentoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] AquecimentoRequest request)
        {
            //Console.WriteLine($"DEBUG => Tempo: {request.TempoEmSegundos}, Potência: {request.Potencia}, Pré-definido: {request.UsarProgramaPredefinido}");

            if (request == null || (!request.UsarProgramaPredefinido &&
                (request.TempoEmSegundos is null || request.TempoEmSegundos < 1 || request.TempoEmSegundos > 120)))
            {
                return BadRequest(new { error = "Tempo inválido. Deve estar entre 1 e 120 segundos." });
            }

            try
            {
                var aquecimento = new Aquecimento(
                    request.TempoEmSegundos.Value,
                    request.Potencia,
                    request.UsarProgramaPredefinido
                );

                int minutos = aquecimento.TempoTotalSegundos / 60;
                int segundos = aquecimento.TempoTotalSegundos % 60;
                string tempoFormatado = $"{minutos:D2}:{segundos:D2}";

                string resultado = new string('.', aquecimento.Potencia);

                return Ok(new
                {
                    tempoFormatado,
                    potenciaUtilizada = aquecimento.Potencia,
                    resultado
                });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
