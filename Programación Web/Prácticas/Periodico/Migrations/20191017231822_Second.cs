using Microsoft.EntityFrameworkCore.Migrations;

namespace Periodico.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_noticias_categorias_categoriaId",
                table: "noticias");

            migrationBuilder.AlterColumn<int>(
                name: "categoriaId",
                table: "noticias",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_noticias_categorias_categoriaId",
                table: "noticias",
                column: "categoriaId",
                principalTable: "categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_noticias_categorias_categoriaId",
                table: "noticias");

            migrationBuilder.AlterColumn<int>(
                name: "categoriaId",
                table: "noticias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_noticias_categorias_categoriaId",
                table: "noticias",
                column: "categoriaId",
                principalTable: "categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
