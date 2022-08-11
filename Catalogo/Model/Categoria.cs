using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.Model;

[Table("Categorias")]
public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    [Key]
    public int CategoriaId { get; set; }
    [Required]
    [StringLength(80)]
    public string Nome { get; set; } = default!;
    [Required]
    [StringLength(300)]
    public string ImagemUrl { get; set; } = default!;
    

    public ICollection<Produto> Produtos { get; set; } = default!;
}
