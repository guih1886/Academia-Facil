using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaFacil.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoaexclusãoparanãopermitidoemcasodeFKparaoutrastabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_RelacaoCargas_RelacaoCargasId",
                table: "Equipamentos");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_RelacaoCargas_RelacaoCargasId",
                table: "Equipamentos",
                column: "RelacaoCargasId",
                principalTable: "RelacaoCargas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_RelacaoCargas_RelacaoCargasId",
                table: "Equipamentos");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_RelacaoCargas_RelacaoCargasId",
                table: "Equipamentos",
                column: "RelacaoCargasId",
                principalTable: "RelacaoCargas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
