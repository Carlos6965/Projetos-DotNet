using CrudClienteCidadeEstado.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CrudClienteCidadeEstado.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Estado> Estados { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<Cliente> Clientes { get; set; }

    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<DateOnly>()
               .HaveConversion<DateOnlyConverter>()
               .HaveColumnType("date");
    }
}
