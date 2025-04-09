using System;
using MicroOndas.Domain.Interfaces;

namespace MicroOndas.Domain.Entities
{
    internal class Frango : IProgramaAquecimento
    {
        public String Nome => "Frango";
        public string Alimento => "Frango (qualquer corte)";
        public int TempoEmSegundos => 480;
        public int Potencia => 7;
        public string Instrucoes => "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o\r\ndescongelamento uniforme.";
    }
}
