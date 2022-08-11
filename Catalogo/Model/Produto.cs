using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Catalogo.Model;

[Table("Produtos")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }
    [Required]
    [StringLength(80)]
    public string Nome { get; set; } = default!;
    [Required]
    [StringLength(300)]
    public string Descricao { get; set; } = default!;
    [Required]
    [Column(TypeName = "double(10,2)")]
    
    public double Preco { get; set; }
    [NotMapped]
    public string ImagemUrl { get; set; } = default!;
    
    public double Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

    public int CategoriaId { get; set; }
    [JsonIgnore]
    public Categoria Categoria { get; set; } = default!;
}
