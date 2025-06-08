namespace crud_produto_fornecedor_netcore.Models
{
    public class Fornecedor

    {

        public int FornecedorId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;

        public ICollection<Produto>? Produtos { get; set; }

    }
}
