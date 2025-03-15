using Microsoft.EntityFrameworkCore;
using RuesCore.Models.Entities;

namespace RuesInfrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ActividadEconomica> ActividadesEconomicas { get; set; }
    public DbSet<CategoriaDeMatricula> CategoriasDeMatriculas { get; set; }
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<EstadoMatricula> EstadosMatriculas { get; set; }
    public DbSet<RepresentanteLegal> RepresentantesLegales { get; set; }
    public DbSet<TipoDeOrganizacion> TiposDeOrganizaciones { get; set; }
    public DbSet<TipoDeSociedad> TiposDeSociedades { get; set; }
    public DbSet<TipoDocumento> TiposDeDocumentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActividadEconomica>().HasData(
            new ActividadEconomica
            {
                Id = 1,
                Nombre =
                    "Actividades de desarrollo de sistemas informáticos (planificación, análisis, diseño, programación, pruebas)",
                Codigo = "6201"
            },
            new ActividadEconomica
            {
                Id = 2,
                Nombre =
                    "Comercio al por menor de computadores, equipos periféricos, programas de informática y equipos de telecomunicaciones en establecimientos especializados",
                Codigo = "4741"
            },
            new ActividadEconomica
            {
                Id = 3,
                Nombre = "Actividades de agencias de cobranza y oficinas de calificación crediticia",
                Codigo = "8291"
            },
            new ActividadEconomica
            {
                Id = 4,
                Nombre = "Actividades de bibliotecas y archivos",
                Codigo = "9102"
            });
        modelBuilder.Entity<TipoDocumento>().HasData(
            new TipoDocumento
            {
                Id = 1,
                Nombre = "Cedula de ciudadania",
                Codigo = "CC"
            },
            new TipoDocumento
            {
                Id = 2,
                Nombre = "Cedula de extranjeria",
                Codigo = "CE"
            });
        modelBuilder.Entity<CategoriaDeMatricula>().HasData(
            new CategoriaDeMatricula
            {
                Id = 1,
                Nombre = "Persona Juridica",
                Codigo = "01"
            },
            new CategoriaDeMatricula
            {
                Id = 2,
                Nombre = "Persona Natural",
                Codigo = "02"
            },
            new CategoriaDeMatricula
            {
                Id = 3,
                Nombre = "Sociedad",
                Codigo = "03"
            },
            new CategoriaDeMatricula
            {
                Id = 4,
                Nombre = "Establecimiento de Comercio",
                Codigo = "04"
            });
        modelBuilder.Entity<TipoDeOrganizacion>().HasData(
            new TipoDeOrganizacion
            {
                Id = 1,
                Nombre = "Sociedad Limitada",
                Codigo = "Ltda"
            },
            new TipoDeOrganizacion
            {
                Id = 2,
                Nombre = "Empresa Unipersonal",
                Codigo = "EU"
            },
            new TipoDeOrganizacion
            {
                Id = 3,
                Nombre = "Sociedad por acciones simplificada",
                Codigo = "SAS"
            });
        modelBuilder.Entity<TipoDeSociedad>().HasData(
            new TipoDeSociedad
            {
                Id = 1,
                Nombre = "Sociedad Comercial",
                Codigo = "01"
            });
        modelBuilder.Entity<EstadoMatricula>().HasData(
            new EstadoMatricula
            {
                Id = 1,
                Nombre = "Activo",
                Codigo = "01"
            },
            new EstadoMatricula
            {
                Id = 2,
                Nombre = "Inactivo",
                Codigo = "02"
            });
    }
}