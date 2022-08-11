using Microsoft.EntityFrameworkCore;
using Catalogo.Model;

namespace Catalogo.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
     

    public DbSet<Categoria> Categorias { get; set; } = default!;
    public DbSet<Produto> Produtos { get; set; } = default!;
}
