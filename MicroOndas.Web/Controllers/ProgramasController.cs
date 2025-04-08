using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicroOndas.Domain.Services; // ou o caminho real da classe
using MicroOndas.Domain.Models;
using MicroOndas.Domain.Interfaces;
using MicroOndas.Web.DTOs;// se esse for o caminho



namespace MicroOndas.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgramasController : ControllerBase
    {
        private readonly ProgramasAquecimentoService _preDefinidosService;
        private readonly ProgramaCustAquecimentoService _customizadosService;

        public ProgramasController(
            ProgramasAquecimentoService preDefinidosService,
            ProgramaCustAquecimentoService customizadosService)
        {
            _preDefinidosService = preDefinidosService;
            _customizadosService = customizadosService;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var preDefinidos = _preDefinidosService
                .ObterTodos()
                .Select(p => new ProgramaDTO
                {
                    Nome = p.Nome,
                    Alimento = p.Alimento,
                    Potencia = p.Potencia,
                    //Caractere = p.Caractere,
                    TempoEmSegundos = p.TempoEmSegundos,
                    Instrucoes = p.Instrucoes,
                    Personalizado = false
                });

            var customizados = _customizadosService
                .ObterTodos()
                .Select(p => new ProgramaDTO
                {
                    Nome = p.Nome,
                    Alimento = p.Alimento,
                    Potencia = p.Potencia,
                    Caractere = p.Caractere,
                    TempoEmSegundos = p.TempoEmSegundos,
                    Instrucoes = p.Instrucoes,
                    Personalizado = true
                });

            var todos = preDefinidos.Concat(customizados).ToList();
            return Ok(todos);
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] ProgramaAquecimento novoPrograma)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _customizadosService.Adicionar(novoPrograma);
            return CreatedAtAction(nameof(ObterTodos), novoPrograma);
        }
    }

}

