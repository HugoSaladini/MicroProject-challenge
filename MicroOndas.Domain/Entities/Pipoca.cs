using System;
using MicroOndas.Domain.Interfaces;

namespace MicroOndas.Domain.Entities
{
    internal class Pipoca : IProgramaAquecimento
    {
        public String Nome => "Pipoca";
        public string Alimento => "Pipoca (de micro-ondas)";
        public int TempoEmSegundos => 180;
        public int Potencia => 7;
        public string Instrucoes => "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um\r\nestouro e outro, interrompa o aquecimento.";
    }
}
