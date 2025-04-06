using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndas.Domain.Models
{
    public class AquecimentoResponse
    {
        public string Resultado { get; set; }
        public string TempoFormatado { get; set; }
        public int PotenciaUtilizada { get; set; }


    }
}
