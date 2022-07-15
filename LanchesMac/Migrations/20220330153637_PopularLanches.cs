using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco)" +
                "VALUES(1,'Pão, Hamburguer, Ovo, Presunto, Queijo e Batata Palha','Pão, Hamburguer, Ovo, Presunto, Queijo e Batata Palha', 1, 'https://www.macoratti.net/Imagens/lanches/cheeseburguer1.jpg','https://www.macoratti.net/Imagens/lanches/cheeseburguer1.jpg',0,'Cheese Burguer', 12.50 )");

            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco)" +
                "VALUES(2,'Pão, Hamburguer Vegetal, Queijo e Batata Palha','Pão, Hamburguer Vegetal, Queijo e Batata Palha', 1, 'https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',0,'Lanche Vegetariano', 19.50 )");

            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco)" +
                "VALUES(2,'Pão, Hamburguer Vegetal, Cenoura e Alface','Pão, Hamburguer Vegetal, Cenoura e Alface', 1, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',1,'Lanche Natural', 14.50 )");

            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco)" +
                "VALUES(1,'Tudo e muito mais','Tudo e muito mais', 1, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',1,'X-Tudão', 22.50 )");

            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco)" +
                "VALUES(1,'Hamburguer e Salada','Hamburguer e Salada', 1, 'https://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','https://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',0,'X-Salada', 13.50 )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
