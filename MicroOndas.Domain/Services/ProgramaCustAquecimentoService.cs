using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MicroOndas.Domain.Models;

namespace MicroOndas.Domain.Services
{
    public class ProgramaCustAquecimentoService
    {
        private readonly string _caminhoArquivo = "programas_customizados.json";
        private List<ProgramaAquecimento> _programas;

        public ProgramaCustAquecimentoService()
        {
            CarregarProgramas();
        }

        private void CarregarProgramas()
        {
            if (File.Exists(_caminhoArquivo))
            {
                string json = File.ReadAllText(_caminhoArquivo);
                _programas = JsonSerializer.Deserialize<List<ProgramaAquecimento>>(json) ?? new List<ProgramaAquecimento>();
            }
            else
            {
                _programas = new List<ProgramaAquecimento>();
            }
        }

        private void SalvarProgramas()
        {
            var json = JsonSerializer.Serialize(_programas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_caminhoArquivo, json);
        }

        public IEnumerable<ProgramaAquecimento> ObterTodos() => _programas;

        public void Adicionar(ProgramaAquecimento programa)
        {
            _programas.Add(programa);
            SalvarProgramas();
        }
    }
}
