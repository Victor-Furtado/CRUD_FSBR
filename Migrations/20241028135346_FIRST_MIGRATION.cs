using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUD_FSBR.Migrations
{
    /// <inheritdoc />
    public partial class FIRST_MIGRATION : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Npu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CadastradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Processos",
                columns: new[] { "Id", "CadastradoEm", "Municipio", "Nome", "Npu", "UF", "VisualizadoEm" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"5300108\",\"nome\":\"Brasília\"}", "Processo Teste 1", "1234567-89.1234.1.56.7890", "DF", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"3304557\",\"nome\":\"Rio de Janeiro\"}", "Processo Teste 2", "2345678-10.5678.2.45.1234", "RJ", new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"3106200\",\"nome\":\"Belo Horizonte\"}", "Processo Teste 3", "3456789-12.3456.3.67.4567", "MG", new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2927408\",\"nome\":\"Salvador\"}", "Processo Teste 4", "4567890-14.6789.4.12.9876", "BA", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"4314902\",\"nome\":\"Porto Alegre\"}", "Processo Teste 5", "5678901-16.2345.5.34.5432", "RS", new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"4106902\",\"nome\":\"Curitiba\"}", "Processo Teste 6", "6789012-18.5678.6.78.1234", "PR", new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"4205407\",\"nome\":\"Florianópolis\"}", "Processo Teste 7", "7890123-20.1234.7.89.5678", "SC", new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"1302603\",\"nome\":\"Manaus\"}", "Processo Teste 8", "8901234-21.3456.8.23.6789", "AM", new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2304400\",\"nome\":\"Fortaleza\"}", "Processo Teste 9", "9012345-23.6789.9.12.7890", "CE", new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2611606\",\"nome\":\"Recife\"}", "Processo Teste 10", "1234567-25.2345.1.56.1234", "PE", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"5208707\",\"nome\":\"Goiânia\"}", "Processo Teste 11", "2345678-26.5678.2.45.2345", "GO", new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"3205309\",\"nome\":\"Vitória\"}", "Processo Teste 12", "3456789-28.1234.3.67.4567", "ES", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2704302\",\"nome\":\"Maceió\"}", "Processo Teste 13", "4567890-30.6789.4.12.6789", "AL", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2507507\",\"nome\":\"João Pessoa\"}", "Processo Teste 14", "5678901-32.2345.5.34.7890", "PB", new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2408102\",\"nome\":\"Natal\"}", "Processo Teste 15", "6789012-34.5678.6.78.8901", "RN", new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2800308\",\"nome\":\"Aracaju\"}", "Processo Teste 16", "7890123-36.1234.7.89.0123", "SE", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"5300108\",\"nome\":\"Brasília\"}", "Processo Teste 17", "8901234-38.3456.8.23.1234", "DF", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2111300\",\"nome\":\"São Luís\"}", "Processo Teste 18", "9012345-40.6789.9.12.2345", "MA", new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"2211001\",\"nome\":\"Teresina\"}", "Processo Teste 19", "1234567-42.2345.1.56.3456", "PI", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"1501402\",\"nome\":\"Belém\"}", "Processo Teste 20", "2345678-44.5678.2.45.4567", "PA", new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"1721000\",\"nome\":\"Palmas\"}", "Processo Teste 21", "3456789-46.1234.3.67.5678", "TO", new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"1200401\",\"nome\":\"Rio Branco\"}", "Processo Teste 22", "4567890-48.6789.4.12.6789", "AC", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"1600303\",\"nome\":\"Macapá\"}", "Processo Teste 23", "5678901-50.2345.5.34.7890", "AP", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"1400100\",\"nome\":\"Boa Vista\"}", "Processo Teste 24", "6789012-52.5678.6.78.8901", "RR", new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"1302603\",\"nome\":\"Manaus\"}", "Processo Teste 25", "7890123-54.1234.7.89.9012", "AM", new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"1100205\",\"nome\":\"Porto Velho\"}", "Processo Teste 26", "8901234-56.3456.8.23.1234", "RO", new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"5103403\",\"nome\":\"Cuiabá\"}", "Processo Teste 27", "9012345-58.6789.9.12.2345", "MT", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"5002704\",\"nome\":\"Campo Grande\"}", "Processo Teste 28", "1234567-60.2345.1.56.3456", "MS", new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"3106200\",\"nome\":\"Belo Horizonte\"}", "Processo Teste 29", "2345678-62.5678.2.45.4567", "MG", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"id\":\"3304557\",\"nome\":\"Rio de Janeiro\"}", "Processo Teste 30", "3456789-64.1234.3.67.5678", "RJ", new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processos");
        }
    }
}
