﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RuesInfrastructure.Persistence;

#nullable disable

namespace RuesInfrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250315105308_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RuesCore.Models.Entities.ActividadEconomica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("ActividadesEconomicas");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.CategoriaDeMatricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoriasDeMatriculas");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CamaraDeComercio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoriaDeMatriculaId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoMatriculaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaDeActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeCancelacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeMatricula")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeRenovacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDeMatricula")
                        .HasColumnType("int");

                    b.Property<int>("RepresentanteLegalId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDeOrganizacionId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDeSociedadId")
                        .HasColumnType("int");

                    b.Property<int?>("UltimoAñoRenovado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaDeMatriculaId");

                    b.HasIndex("EstadoMatriculaId");

                    b.HasIndex("RepresentanteLegalId");

                    b.HasIndex("TipoDeOrganizacionId");

                    b.HasIndex("TipoDeSociedadId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.EstadoMatricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadosMatriculas");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.RepresentanteLegal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CargoDeLaEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeNombramiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("RepresentantesLegales");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.TipoDeOrganizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposDeOrganizaciones");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.TipoDeSociedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposDeSociedades");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposDeDocumentos");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.ActividadEconomica", b =>
                {
                    b.HasOne("RuesCore.Models.Entities.Empresa", "Empresa")
                        .WithMany("ActividadesEconomicas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.Empresa", b =>
                {
                    b.HasOne("RuesCore.Models.Entities.CategoriaDeMatricula", "CategoriaDeMatricula")
                        .WithMany()
                        .HasForeignKey("CategoriaDeMatriculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuesCore.Models.Entities.EstadoMatricula", "EstadoMatricula")
                        .WithMany()
                        .HasForeignKey("EstadoMatriculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuesCore.Models.Entities.RepresentanteLegal", "RepresentanteLegal")
                        .WithMany("Empresas")
                        .HasForeignKey("RepresentanteLegalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuesCore.Models.Entities.TipoDeOrganizacion", "TipoDeOrganizacion")
                        .WithMany()
                        .HasForeignKey("TipoDeOrganizacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuesCore.Models.Entities.TipoDeSociedad", "TipoDeSociedad")
                        .WithMany()
                        .HasForeignKey("TipoDeSociedadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaDeMatricula");

                    b.Navigation("EstadoMatricula");

                    b.Navigation("RepresentanteLegal");

                    b.Navigation("TipoDeOrganizacion");

                    b.Navigation("TipoDeSociedad");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.RepresentanteLegal", b =>
                {
                    b.HasOne("RuesCore.Models.Entities.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("TipoDocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.Empresa", b =>
                {
                    b.Navigation("ActividadesEconomicas");
                });

            modelBuilder.Entity("RuesCore.Models.Entities.RepresentanteLegal", b =>
                {
                    b.Navigation("Empresas");
                });
#pragma warning restore 612, 618
        }
    }
}
