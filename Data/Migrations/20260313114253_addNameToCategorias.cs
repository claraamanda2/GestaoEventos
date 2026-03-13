using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoEventos.Data.Migrations
{
    /// <inheritdoc />
    public partial class addNameToCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Categorias");
        }
    }
}
