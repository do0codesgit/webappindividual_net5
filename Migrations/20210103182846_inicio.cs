using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace do0.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "do0Eventos",
                columns: table => new
                {
                    do0EventoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rascunho = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: true),
                    do0Avatar = table.Column<string>(type: "TEXT", nullable: true),
                    do0User = table.Column<string>(type: "TEXT", nullable: true),
                    TipoEvento = table.Column<string>(type: "TEXT", nullable: true),
                    DataEvento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    ResponsavelEvento = table.Column<string>(type: "TEXT", nullable: true),
                    NomeHomenageado = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Identidade = table.Column<string>(type: "TEXT", nullable: true),
                    EnderecoCompleto = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone2 = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone3 = table.Column<string>(type: "TEXT", nullable: true),
                    Notas = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_do0Eventos", x => x.do0EventoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "do0Eventos");
        }
    }
}
