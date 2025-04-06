// Interfaces/IAquecimentoService.cs
using MicroOndas.Domain.Enums;

namespace MicroOndas.Domain.Interfaces
{
    public interface IAquecimentoService
    {
        void Iniciar();
        void PausarOuCancelar();
        void AcrescentarTempo(int segundos);
        void Finalizar();
        EstadoAquecimento Estado { get; }
        int TempoRestanteSegundos { get; }
        string GerarStringAquecimento();
    }
}
