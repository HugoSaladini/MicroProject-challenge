using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroOndas.Domain.Interfaces;

namespace MicroOndas.Domain.Entities
{
    internal class CarneDeBoi : IProgramaAquecimento
    {
        public String Nome => "Carne de Boi";
        public string Alimento => "Carne em pedaço ou fatias";
        public int TempoEmSegundos => 840;
        public int Potencia => 4;
        public string Instrucoes => "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o\r\ndescongelamento uniforme.";
    }
}
