using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDosPets.Migrations
{
    public partial class SegundaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cachorro",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "Gato",
                table: "Categorias");

            migrationBuilder.AddColumn<string>(
                name: "CategoriaNome",
                table: "Categorias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaNome",
                table: "Categorias");

            migrationBuilder.AddColumn<string>(
                name: "Cachorro",
                table: "Categorias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gato",
                table: "Categorias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
