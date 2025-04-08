using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroOndas.Domain.Interfaces;

namespace MicroOndas.Domain.Entities
{
    internal class Feijao : IProgramaAquecimento
    {
        public String Nome => "Feijão";
        public string Alimento => "Feijão congelado";
        public int TempoEmSegundos => 840;
        public int Potencia => 9;
        public string Instrucoes => "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo\r\npode perder resistência em altas temperaturas.";
    }
}
