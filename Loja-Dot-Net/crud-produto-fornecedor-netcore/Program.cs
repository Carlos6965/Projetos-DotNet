using crud_produto_fornecedor_netcore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controllers com views
builder.Services.AddControllersWithViews();

// Configura o DbContext com conexão ao PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configura tratamento de erro para produção
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// Middleware padrão
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Rota padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
