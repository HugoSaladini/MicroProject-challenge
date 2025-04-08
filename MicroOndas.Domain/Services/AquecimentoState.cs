using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndas.Domain.Services
{
    public class AquecimentoState
    {
        public int TempoRestante { get; set; } = 0;
        public int Potencia { get; set; } = 10;
        public string Status { get; set; } = "Aguardando";
        public string Resultado { get; set; } = ""; // <-- Adicionado aqui ✅

        private static readonly AquecimentoState _instancia = new AquecimentoState();
        public static AquecimentoState Instancia => _instancia;

        private AquecimentoState() { }

        public void Reset()
        {
            TempoRestante = 0;
            Potencia = 10;
            Status = "Aguardando";
            Resultado = ""; // <-- Zera o resultado quando reseta também
        }

    }
}
