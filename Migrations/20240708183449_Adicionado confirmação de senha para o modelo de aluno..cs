using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaFacil.Migrations
{
    /// <inheritdoc />
    public partial class Adicionadoconfirmaçãodesenhaparaomodelodealuno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmacaoSenha",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmacaoSenha",
                table: "Alunos");
        }
    }
}
