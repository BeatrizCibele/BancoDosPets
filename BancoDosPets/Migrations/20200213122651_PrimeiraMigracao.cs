using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDosPets.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cachorro = table.Column<string>(maxLength: 100, nullable: true),
                    Gato = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Sexo = table.Column<string>(maxLength: 1, nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    ValorEsperado = table.Column<decimal>(nullable: false),
                    ValorRecebido = table.Column<decimal>(nullable: false),
                    DescricaoCurta = table.Column<string>(maxLength: 100, nullable: true),
                    DescricaoLonga = table.Column<string>(maxLength: 200, nullable: true),
                    ImagemUrl = table.Column<string>(maxLength: 200, nullable: true),
                    ImagemThumbnail = table.Column<string>(maxLength: 200, nullable: true),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                    table.ForeignKey(
                        name: "FK_Pets_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_CategoriaId",
                table: "Pets",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
