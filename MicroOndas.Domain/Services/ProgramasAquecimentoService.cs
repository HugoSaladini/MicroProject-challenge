using System.Collections.Generic;
using MicroOndas.Domain.Entities;
using MicroOndas.Domain.Interfaces;

namespace MicroOndas.Domain.Services
{
    public class ProgramasAquecimentoService
    {
        public List<IProgramaAquecimento> ObterTodos()
        {
            return new List<IProgramaAquecimento>
            {
                new Pipoca(),
                new Leite(),
                new CarneDeBoi(),
                new Frango(),
                new Feijao()
            };
        }
    }
}
