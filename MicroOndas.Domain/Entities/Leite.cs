using System;
using MicroOndas.Domain.Interfaces;

namespace MicroOndas.Domain.Entities
{
    internal class Leite : IProgramaAquecimento
    {
        public String Nome => "Leite";
        public string Alimento => "Leite";
        public int TempoEmSegundos => 300;
        public int Potencia => 5;
        public string Instrucoes => "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode\r\ncausar fervura imediata causando risco de queimaduras.";
    }
}
