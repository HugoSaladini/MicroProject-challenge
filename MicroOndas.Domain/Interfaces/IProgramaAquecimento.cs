using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
