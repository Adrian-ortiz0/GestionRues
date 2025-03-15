using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RuesInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasDeMatriculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasDeMatriculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosMatriculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosMatriculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeOrganizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeOrganizaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeSociedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeSociedades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepresentantesLegales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargoDeLaEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeNombramiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentantesLegales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepresentantesLegales_TiposDeDocumentos_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TiposDeDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaDeMatriculaId = table.Column<int>(type: "int", nullable: false),
                    TipoDeSociedadId = table.Column<int>(type: "int", nullable: false),
                    TipoDeOrganizacionId = table.Column<int>(type: "int", nullable: false),
                    NumeroDeMatricula = table.Column<int>(type: "int", nullable: false),
                    CamaraDeComercio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeMatricula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDeCancelacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoMatriculaId = table.Column<int>(type: "int", nullable: false),
                    FechaDeRenovacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UltimoAñoRenovado = table.Column<int>(type: "int", nullable: true),
                    FechaDeActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RepresentanteLegalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_CategoriasDeMatriculas_CategoriaDeMatriculaId",
                        column: x => x.CategoriaDeMatriculaId,
                        principalTable: "CategoriasDeMatriculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresas_EstadosMatriculas_EstadoMatriculaId",
                        column: x => x.EstadoMatriculaId,
                        principalTable: "EstadosMatriculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresas_RepresentantesLegales_RepresentanteLegalId",
                        column: x => x.RepresentanteLegalId,
                        principalTable: "RepresentantesLegales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresas_TiposDeOrganizaciones_TipoDeOrganizacionId",
                        column: x => x.TipoDeOrganizacionId,
                        principalTable: "TiposDeOrganizaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresas_TiposDeSociedades_TipoDeSociedadId",
                        column: x => x.TipoDeSociedadId,
                        principalTable: "TiposDeSociedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActividadesEconomicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadesEconomicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActividadesEconomicas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesEconomicas_EmpresaId",
                table: "ActividadesEconomicas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_CategoriaDeMatriculaId",
                table: "Empresas",
                column: "CategoriaDeMatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_EstadoMatriculaId",
                table: "Empresas",
                column: "EstadoMatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_RepresentanteLegalId",
                table: "Empresas",
                column: "RepresentanteLegalId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoDeOrganizacionId",
                table: "Empresas",
                column: "TipoDeOrganizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoDeSociedadId",
                table: "Empresas",
                column: "TipoDeSociedadId");

            migrationBuilder.CreateIndex(
                name: "IX_RepresentantesLegales_TipoDocumentoId",
                table: "RepresentantesLegales",
                column: "TipoDocumentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActividadesEconomicas");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "CategoriasDeMatriculas");

            migrationBuilder.DropTable(
                name: "EstadosMatriculas");

            migrationBuilder.DropTable(
                name: "RepresentantesLegales");

            migrationBuilder.DropTable(
                name: "TiposDeOrganizaciones");

            migrationBuilder.DropTable(
                name: "TiposDeSociedades");

            migrationBuilder.DropTable(
                name: "TiposDeDocumentos");
        }
    }
}
