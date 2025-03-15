using RuesCore.Interfaces;
using RuesCore.Models.DTOs;
using RuesCore.Models.Entities;

namespace RuesCore.Services;

public class EmpresaService
{
    private readonly IEmpresaRespository  _empresaRepository;

    public EmpresaService(IEmpresaRespository empresaRepository)
    {
        _empresaRepository = empresaRepository;
    }

    public async Task<Empresa> GetEmpresaAsync(int id)
    {
        return await _empresaRepository.GetEmpresaByIdAsync(id);
    }

    public async Task<IEnumerable<Empresa>> GetAllEmpresasAsync()
    {
        return await _empresaRepository.GetAllEmpresasAsync();
    }

    public async Task AddEmpresaAsync(EmpresaDto empresaDto)
    {
        var empresa = new Empresa
        {
            Identificacion = empresaDto.Identificacion,
            Nombre = empresaDto.Nombre,
            CategoriaDeMatricula = new CategoriaDeMatricula { Id = empresaDto.CategoriaMatriculaId },
            TipoDeSociedad = new TipoDeSociedad { Id = empresaDto.TipoDeSociedadId },
            TipoDeOrganizacion = new TipoDeOrganizacion { Id = empresaDto.TipoDeOrganizacionId },
            NumeroDeMatricula = empresaDto.NumeroDeMatricula,
            CamaraDeComercio = empresaDto.CamaraDeComercio,
            FechaDeMatricula = empresaDto.FechaDeMatricula,
            EstadoMatricula = new EstadoMatricula { Id = empresaDto.EstadoMatriculaId },
            ActividadesEconomicas = empresaDto.ActividadesEconomicas.Select(id => new ActividadEconomica { Id = id }).ToList(),
            RepresentanteLegal = new RepresentanteLegal { Id = empresaDto.RepresentanteLegalId }
        };

        await _empresaRepository.AddEmpresaAsync(empresa);
    }

    public async Task UpdateEmpresaAsync(Empresa empresa)
    {
        await _empresaRepository.UpdateEmpresaAsync(empresa);
    }

    public async Task DeleteEmpresaAsync(int id)
    {
        await _empresaRepository.DeleteEmpresaAsync(id);
    }
}