namespace MicroOndas.Web.DTOs
{
    public class ProgramaDTO
    {
        public string Nome { get; set; }
        public string Alimento { get; set; }
        public int Potencia { get; set; }
        public char Caractere { get; set; }
        public int TempoEmSegundos { get; set; }
        public string Instrucoes { get; set; }
        public bool Personalizado { get; set; }
    }
}
