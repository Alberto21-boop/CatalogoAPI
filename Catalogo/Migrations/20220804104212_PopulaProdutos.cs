using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,Estoque,DataCadastro,CategoriaId)" + 
                "Values('Coca-Cola Zero','Refrigerante de Cola 350 mls',5.45,50,now(),1)");
            
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,Estoque,DataCadastro,CategoriaId)" +
                "Values('Lanche de Atum','Lanche de Atum Com Maionese',8.50,10,now(),2)");
            
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,Estoque,DataCadastro,CategoriaId)" +
                "Values('Pudim 100 g','Pudim de Leite Condensado 100g',6.75,20,now(),3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
