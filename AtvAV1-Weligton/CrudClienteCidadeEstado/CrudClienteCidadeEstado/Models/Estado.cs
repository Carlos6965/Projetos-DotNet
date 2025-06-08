namespace CrudClienteCidadeEstado.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Sigla { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public ICollection<Cidade>? Cidades { get; set; }
    }
}
