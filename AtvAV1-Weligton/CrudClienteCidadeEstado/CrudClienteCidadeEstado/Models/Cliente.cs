namespace CrudClienteCidadeEstado.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateOnly DataNasc { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; } = string.Empty;

        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
