// Models/Aquecimento.cs
using System;
using MicroOndas.Domain.Enums;

namespace MicroOndas.Domain.Models
{
    public class Aquecimento
    {
        public int TempoTotalSegundos { get; private set; }
        public int TempoRestanteSegundos { get; private set; }
        public int Potencia { get; private set; }
        public EstadoAquecimento Estado { get; private set; }

        public Aquecimento(int tempoSegundos, int? potencia = null, bool usarProgramaPredefinido = false)
        {
            ValidarParametros(tempoSegundos, potencia, usarProgramaPredefinido);
            TempoTotalSegundos = tempoSegundos;
            TempoRestanteSegundos = tempoSegundos;
            Potencia = potencia ?? 10;
            Estado = EstadoAquecimento.NaoIniciado;
        }

        public void Iniciar()
        {
            if (Estado == EstadoAquecimento.NaoIniciado || Estado == EstadoAquecimento.Pausado)
                Estado = EstadoAquecimento.EmExecucao;
        }

        public void PausarOuCancelar()
        {
            if (Estado == EstadoAquecimento.EmExecucao)
            {
                Estado = EstadoAquecimento.Pausado;
            }
            else if (Estado == EstadoAquecimento.Pausado)
            {
                Estado = EstadoAquecimento.Cancelado;
                TempoRestanteSegundos = 0;
            }
        }

        public void AcrescentarTempo(int segundos)
        {
            if (Estado == EstadoAquecimento.EmExecucao)
                TempoRestanteSegundos += segundos;
        }

        public void Finalizar()
        {
            Estado = EstadoAquecimento.Finalizado;
            TempoRestanteSegundos = 0;
        }

        private void ValidarParametros(int tempo, int? potencia, bool usarProgramaPredefinido)
        {
            if (!usarProgramaPredefinido && (tempo < 1 || tempo > 120))
                throw new ArgumentException("Tempo deve estar entre 1 e 120 segundos.");

            if (potencia.HasValue && (potencia < 1 || potencia > 10))
                throw new ArgumentException("Potência deve estar entre 1 e 10.");
        }

    }
}
