using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.DTOs;
using RuesCore.Models.Entities;
using RuesInfrastructure.Persistence;
namespace RuesInfrastructure.Repositories;

public class EmpresaRepository : IEmpresaRespository
{
    
    private readonly AppDbContext _context;

    public EmpresaRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Empresa>> GetAllEmpresasAsync()
    {
        return await _context.Empresas.ToListAsync();
    }

    public async Task<IEnumerable<EmpresaResponseDto>> GetAllEmpresasResponseAsync()
    {
        return await _context.Empresas
            .Include(e => e.CategoriaDeMatricula)
            .Include(e => e.TipoDeSociedad)
            .Include(e => e.TipoDeOrganizacion)
            .Include(e => e.EstadoMatricula)
            .Include(e => e.ActividadesEconomicas)
            .Include(e => e.RepresentanteLegal)
            .Select(e => new EmpresaResponseDto
            {
                Id = e.Id,
                Identificacion = e.Identificacion,
                Nombre = e.Nombre,
                CategoriaDeMatricula = e.CategoriaDeMatricula != null ? e.CategoriaDeMatricula.Nombre : "",
                TipoDeSociedad = e.TipoDeSociedad != null ? e.TipoDeSociedad.Nombre : "",
                TipoDeOrganizacion = e.TipoDeOrganizacion != null ? e.TipoDeOrganizacion.Nombre : "",
                NumeroDeMatricula = e.NumeroDeMatricula,
                CamaraDeComercio = e.CamaraDeComercio,
                FechaDeMatricula = e.FechaDeMatricula,
                EstadoMatricula = e.EstadoMatricula != null ? e.EstadoMatricula.Nombre : "",
                ActividadesEconomicas = e.ActividadesEconomicas.Select(a => a.Nombre).ToList(),
                CodigoActividadesEconomicas = e.ActividadesEconomicas.Select(a => a.Codigo).ToList(),
                RepresentanteLegalDocumento = e.RepresentanteLegal.Documento,
                FechaDeRenovacion = e.FechaDeRenovacion.ToString() == null ? "0" : e.FechaDeRenovacion.ToString(),
                UltimoAñoRenovado = e.UltimoAñoRenovado.ToString() == null ? "0" : e.FechaDeRenovacion.ToString(),
                FechaDeActualizacion = e.FechaDeActualizacion.ToString() == null ? "0" : e.FechaDeRenovacion.ToString(),
                RepresentanteLegal = e.RepresentanteLegal != null 
                    ? $"{e.RepresentanteLegal.Nombre} {e.RepresentanteLegal.Apellido}" 
                    : ""
            })
            .ToListAsync();
    }

    public async Task<Empresa> GetEmpresaByIdAsync(int id)
    {
        var empresa = await _context.Empresas.FirstOrDefaultAsync(e => e.Id == id);
        return empresa;
    }

    public async Task AddEmpresaAsync(Empresa empresa)
    {
        _context.Empresas.Add(empresa);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateEmpresaAsync(Empresa empresa)
    {
        _context.Empresas.Update(empresa);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEmpresaAsync(int id)
    {
        var empresa = await _context.Empresas.FindAsync(id);
        if (empresa != null)
        {
            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<EmpresaResponseDto> GetEmpresaResponseByNombreAsync(string nombre)
    {
        return await _context.Empresas
            .Where(e => e.Nombre.ToLower() == nombre.ToLower())
            .Select(e => new EmpresaResponseDto
            {
                Id = e.Id,
                Identificacion = e.Identificacion,
                Nombre = e.Nombre,
                CategoriaDeMatricula = e.CategoriaDeMatricula != null ? e.CategoriaDeMatricula.Nombre : "",
                TipoDeSociedad = e.TipoDeSociedad != null ? e.TipoDeSociedad.Nombre : "",
                TipoDeOrganizacion = e.TipoDeOrganizacion != null ? e.TipoDeOrganizacion.Nombre : "",
                NumeroDeMatricula = e.NumeroDeMatricula,
                CamaraDeComercio = e.CamaraDeComercio,
                FechaDeMatricula = e.FechaDeMatricula,
                EstadoMatricula = e.EstadoMatricula != null ? e.EstadoMatricula.Nombre : "",
                ActividadesEconomicas = e.ActividadesEconomicas.Select(a => a.Nombre).ToList(),
                RepresentanteLegal = e.RepresentanteLegal != null ? $"{e.RepresentanteLegal.Nombre} {e.RepresentanteLegal.Apellido}" : "",
                RepresentanteLegalDocumento = e.RepresentanteLegal != null ? e.RepresentanteLegal.Documento : ""
            })
            .FirstOrDefaultAsync();
    }

    public async Task UpdateEmpresaResponseAsync(Empresa empresa, UpdateEmpresaDto dto)
    {
        await _context.Entry(empresa)
            .Collection(e => e.ActividadesEconomicas)
            .LoadAsync();
        empresa.Nombre = dto.Nombre;
        empresa.Identificacion = dto.Identificacion;
        empresa.CategoriaDeMatricula = await _context.CategoriasDeMatriculas.FindAsync(dto.CategoriaMatriculaId);
        empresa.TipoDeSociedad = await _context.TiposDeSociedades.FindAsync(dto.TipoDeSociedadId);
        empresa.TipoDeOrganizacion = await _context.TiposDeOrganizaciones.FindAsync(dto.TipoDeOrganizacionId);
        empresa.NumeroDeMatricula = Convert.ToInt32(dto.NumeroDeMatricula);
        empresa.CamaraDeComercio = dto.CamaraDeComercio;
        empresa.FechaDeRenovacion = dto.FechaDeRenovacion;
        empresa.FechaDeActualizacion = dto.FechaDeActualizacion;
        empresa.UltimoAñoRenovado = Convert.ToInt32(dto.UltimoAñoDeActualizacion);
        empresa.EstadoMatricula = await _context.EstadosMatriculas.FindAsync(dto.EstadoMatriculaId);
        var nuevasActividades = await _context.ActividadesEconomicas.Where(a => dto.ActividadesComercialesId.Contains(a.Id))
            .ToListAsync();
        empresa.ActividadesEconomicas = nuevasActividades;
        //empresa.RepresentanteLegal.Nombre = dto.NombreRepresentanteLegal;
        //empresa.RepresentanteLegal.Documento = dto.DocumentoRepresentanteLegal;
        await _context.SaveChangesAsync();
    }
}