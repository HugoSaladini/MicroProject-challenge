namespace MicroOndas.Domain.Interfaces
{
    public interface IProgramaAquecimento
    {
        string Nome { get; }
        string Alimento { get; }
        int TempoEmSegundos { get; }
        int Potencia { get; }
        string Instrucoes { get; }
    }
}
