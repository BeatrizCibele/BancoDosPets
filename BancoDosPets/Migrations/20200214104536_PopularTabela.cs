using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDosPets.Migrations
{
    public partial class PopularTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES ('Cães')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome) VALUES ('Gatos')");

            migrationBuilder.Sql("INSERT INTO Pets (CategoriaId, Nome, Sexo, Idade, ValorEsperado, ValorRecebido, DescricaoCurta, DescricaoLonga, ImagemUrl, ImagemThumbnail) VALUES" +
                "(1,'Tido', 'M', 3, 250, 0, 'Tido quebrou a patinha', 'A médica informou que será necessário cirurgia e listou o preço dos materias','https://i.ibb.co/mtxNYcF/Tido.jpg','https://animalgiftclub-static.myshopblocks.com/images/2019/03/contain/256x256/a95436bbac5488e67025aabe317ec5ab.jpg' )");

            migrationBuilder.Sql("INSERT INTO Pets (CategoriaId,Nome, Sexo, Idade, ValorEsperado, ValorRecebido, DescricaoCurta, DescricaoLonga, ImagemUrl, ImagemThumbnail) VALUES" +
                "(1,'Teco', 'M', 3, 3000, 100, 'Teco precisa de um transplante de rin', 'Fazia algum tempo que eu o via passando mal, consegui pagar as consultas mas não posso arcar com o valor do transplante', 'https://d2ph5fj80uercy.cloudfront.net/04/cat2972.jpg','https://d2ph5fj80uercy.cloudfront.net/04/cat2972.jpg')");

            migrationBuilder.Sql("INSERT INTO Pets (CategoriaId, Nome, Sexo, Idade, ValorEsperado, ValorRecebido, DescricaoCurta, DescricaoLonga, ImagemUrl, ImagemThumbnail) VALUES " +
                "(1, 'Lola','F', 1, 5000, '3500', 'Estou com alergias estranhas', 'Assim que fui achada minha dona reparou que eu me coçava mais que o normal, fui levada ao veterinário e preciso de um tratamento caro, o orçamento saiu por 5000', 'https://i.ibb.co/tpbccL5/Lola.jpg','https://i.ibb.co/tpbccL5/Lola.jpg')");

            migrationBuilder.Sql("INSERT INTO Pets (CategoriaId, Nome, Sexo, Idade, ValorEsperado, ValorRecebido, DescricaoCurta, DescricaoLonga, ImagemUrl, ImagemThumbnail) VALUES" +
                "(2, 'Boris', 'M', '4', 340, 50, 'Preciso de uma microcirugia', 'Um carro atropelou minha patinha na rua, o orçamento da cirurgia saiu por 340', 'https://i.ibb.co/vQmfDzh/Boris.jpg','https://i.ibb.co/vQmfDzh/Boris.jpg')");

            migrationBuilder.Sql("INSERT INTO Pets (CategoriaId, Nome, Sexo, Idade, ValorEsperado, ValorRecebido, DescricaoCurta, DescricaoLonga, ImagemUrl, ImagemThumbnail) VALUES" +
                "(2, 'Bolinha', 'F', 0, 1500, 60, 'Sinto fortes dores ao caminhar', 'Estava brincando com uma cachorra muito maior que eu quando de repente ela caiu em cima de mim, dei mal jeito na coluna e preciso de sessões de fisioterapia', 'https://i.ibb.co/mCR8JNG/Bolinha.jpg', 'https://i.ibb.co/mCR8JNG/Bolinha.jpg')");

            migrationBuilder.Sql("INSERT INTO Pets (CategoriaId, Nome, Sexo, Idade, ValorEsperado, ValorRecebido, DescricaoCurta, DescricaoLonga, ImagemUrl, ImagemThumbnail) VALUES" +
                "(2, 'Algodão', 'M', 7, 600, 30, 'Estou com doença Periodental', 'Minha dona não pode arcar com os custos quem poder fazer doações me ajudará com qualquer valor','https://i.ibb.co/P5nLvCR/Algodao.jpg','https://i.ibb.co/P5nLvCR/Algodao.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
            migrationBuilder.Sql("DELETE FROM Pets");
        }
    }
}
