using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beautysoft.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Procedimentos_ProcedimentoId",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_ProcedimentoId",
                table: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "ProcedimentoId",
                table: "Agendamentos",
                newName: "TipoProcedimento");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Agendamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Agendamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tempo",
                table: "Agendamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Agendamentos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Tempo",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Agendamentos");

            migrationBuilder.RenameColumn(
                name: "TipoProcedimento",
                table: "Agendamentos",
                newName: "ProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_ProcedimentoId",
                table: "Agendamentos",
                column: "ProcedimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Procedimentos_ProcedimentoId",
                table: "Agendamentos",
                column: "ProcedimentoId",
                principalTable: "Procedimentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
