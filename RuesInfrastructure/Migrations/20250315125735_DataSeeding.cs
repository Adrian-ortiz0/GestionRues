using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RuesInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActividadesEconomicas_Empresas_EmpresaId",
                table: "ActividadesEconomicas");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "ActividadesEconomicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "ActividadesEconomicas",
                columns: new[] { "Id", "Codigo", "EmpresaId", "Nombre" },
                values: new object[,]
                {
                    { 1, "6201", null, "Actividades de desarrollo de sistemas informáticos (planificación, análisis, diseño, programación, pruebas)" },
                    { 2, "4741", null, "Comercio al por menor de computadores, equipos periféricos, programas de informática y equipos de telecomunicaciones en establecimientos especializados" },
                    { 3, "8291", null, "Actividades de agencias de cobranza y oficinas de calificación crediticia" },
                    { 4, "9102", null, "Actividades de bibliotecas y archivos" }
                });

            migrationBuilder.InsertData(
                table: "CategoriasDeMatriculas",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "01", "Persona Juridica" },
                    { 2, "02", "Persona Natural" },
                    { 3, "03", "Sociedad" },
                    { 4, "04", "Establecimiento de Comercio" }
                });

            migrationBuilder.InsertData(
                table: "EstadosMatriculas",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "01", "Activo" },
                    { 2, "02", "Inactivo" }
                });

            migrationBuilder.InsertData(
                table: "TiposDeDocumentos",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "CC", "Cedula de ciudadania" },
                    { 2, "CE", "Cedula de extranjeria" }
                });

            migrationBuilder.InsertData(
                table: "TiposDeOrganizaciones",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { 1, "Ltda", "Sociedad Limitada" },
                    { 2, "EU", "Empresa Unipersonal" },
                    { 3, "SAS", "Sociedad por acciones simplificada" }
                });

            migrationBuilder.InsertData(
                table: "TiposDeSociedades",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[] { 1, "01", "Sociedad Comercial" });

            migrationBuilder.AddForeignKey(
                name: "FK_ActividadesEconomicas_Empresas_EmpresaId",
                table: "ActividadesEconomicas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActividadesEconomicas_Empresas_EmpresaId",
                table: "ActividadesEconomicas");

            migrationBuilder.DeleteData(
                table: "ActividadesEconomicas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActividadesEconomicas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActividadesEconomicas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActividadesEconomicas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoriasDeMatriculas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoriasDeMatriculas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoriasDeMatriculas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoriasDeMatriculas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EstadosMatriculas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstadosMatriculas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposDeDocumentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposDeDocumentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposDeOrganizaciones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposDeOrganizaciones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposDeOrganizaciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposDeSociedades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "ActividadesEconomicas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActividadesEconomicas_Empresas_EmpresaId",
                table: "ActividadesEconomicas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
