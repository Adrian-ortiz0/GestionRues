using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RuesInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActividadesEconomicas_Empresas_EmpresaId",
                table: "ActividadesEconomicas");

            migrationBuilder.DropIndex(
                name: "IX_ActividadesEconomicas_EmpresaId",
                table: "ActividadesEconomicas");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "ActividadesEconomicas");

            migrationBuilder.CreateTable(
                name: "ActividadEconomicaEmpresa",
                columns: table => new
                {
                    ActividadesEconomicasId = table.Column<int>(type: "int", nullable: false),
                    EmpresasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadEconomicaEmpresa", x => new { x.ActividadesEconomicasId, x.EmpresasId });
                    table.ForeignKey(
                        name: "FK_ActividadEconomicaEmpresa_ActividadesEconomicas_ActividadesEconomicasId",
                        column: x => x.ActividadesEconomicasId,
                        principalTable: "ActividadesEconomicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActividadEconomicaEmpresa_Empresas_EmpresasId",
                        column: x => x.EmpresasId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadEconomicaEmpresa_EmpresasId",
                table: "ActividadEconomicaEmpresa",
                column: "EmpresasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActividadEconomicaEmpresa");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "ActividadesEconomicas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ActividadesEconomicas",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmpresaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActividadesEconomicas",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmpresaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActividadesEconomicas",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmpresaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActividadesEconomicas",
                keyColumn: "Id",
                keyValue: 4,
                column: "EmpresaId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesEconomicas_EmpresaId",
                table: "ActividadesEconomicas",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActividadesEconomicas_Empresas_EmpresaId",
                table: "ActividadesEconomicas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");
        }
    }
}
