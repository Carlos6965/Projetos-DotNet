using crud_produto_fornecedor_netcore.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_produto_fornecedor_netcore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
