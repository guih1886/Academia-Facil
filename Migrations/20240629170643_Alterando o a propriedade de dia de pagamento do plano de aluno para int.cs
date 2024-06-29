using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaFacil.Migrations
{
    /// <inheritdoc />
    public partial class Alterandooapropriedadedediadepagamentodoplanodealunoparaint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPagamentoPlano",
                table: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "DiaPagamentoPlano",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaPagamentoPlano",
                table: "Alunos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPagamentoPlano",
                table: "Alunos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
