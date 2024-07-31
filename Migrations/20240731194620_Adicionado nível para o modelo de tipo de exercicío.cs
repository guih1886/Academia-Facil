using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaFacil.Migrations
{
    /// <inheritdoc />
    public partial class Adicionadonívelparaomodelodetipodeexercicío : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TiposExercicio",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "TiposExercicio",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "TiposExercicio");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TiposExercicio",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
