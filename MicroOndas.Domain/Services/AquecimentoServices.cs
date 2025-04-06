using MicroOndas.Domain.Models;
using System;
using MicroOndas.Web.Models;

namespace MicroOndas.Web.Services
{
    public class AquecimentoService
    {
        public AquecimentoResponse Aquecer(int? tempo, int? potencia = null)
        {
            // Início rápido: nenhum tempo nem potência informados
            if (!tempo.HasValue && !potencia.HasValue)
            {
                tempo = 30;
                potencia = 10;
            }

            // Validar tempo
            if (!tempo.HasValue || tempo < 1 || tempo > 120)
                throw new ArgumentException("Tempo deve estar entre 1 e 120 segundos");

            // Validar ou assumir potência
            int pot = potencia ?? 10;
            if (pot < 1 || pot > 10)
                throw new ArgumentException("Potência deve estar entre 1 e 10");

            string resultado = string.Empty;

            for (int i = 0; i < tempo; i++)
            {
                resultado += new string('.', pot) + " ";
            }

            resultado += "Aquecimento concluído";

            var tempoFormatado = TimeSpan.FromSeconds(tempo.Value).ToString(@"mm\:ss");

            return new AquecimentoResponse
            {
                Resultado = resultado,
                TempoFormatado = tempoFormatado,
                PotenciaUtilizada = pot
            };
        }
    }
}
