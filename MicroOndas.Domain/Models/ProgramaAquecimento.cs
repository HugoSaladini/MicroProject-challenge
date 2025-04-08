// Models/ProgramaAquecimento.cs
using System;
using MicroOndas.Domain.Interfaces;

namespace MicroOndas.Domain.Models
{
    public class ProgramaAquecimento : IProgramaAquecimento
    {
        public string Nome { get; set; }
        public string Alimento { get; set; }
        public int Potencia { get; set; }
        public char Caractere { get; set; }
        public int TempoEmSegundos { get; set; }
        public string Instrucoes { get; set; } 

        public bool Personalizado { get; set; } = true;

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                throw new ArgumentException("Nome é obrigatório.");
            if (string.IsNullOrWhiteSpace(Alimento))
                throw new ArgumentException("Alimento é obrigatório.");
            if (TempoEmSegundos < 1 || TempoEmSegundos > 120)
                throw new ArgumentException("Tempo deve estar entre 1 e 120 segundos.");
            if (Potencia < 1 || Potencia > 10)
                throw new ArgumentException("Potência deve estar entre 1 e 10.");
        }

        public override string ToString()
        {
            return $"{Nome} - {Alimento} ({TempoEmSegundos}s, Potência {Potencia}, Char: '{Caractere}')";
        }
    }
}
