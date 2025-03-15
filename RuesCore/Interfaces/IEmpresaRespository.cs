using RuesCore.Models.DTOs;
using RuesCore.Models.Entities;

namespace RuesCore.Interfaces;

public interface IEmpresaRespository
{
    Task<IEnumerable<Empresa>> GetAllEmpresasAsync();
    Task<IEnumerable<EmpresaResponseDto>> GetAllEmpresasResponseAsync();
    Task<Empresa> GetEmpresaByIdAsync(int id);
    Task AddEmpresaAsync(Empresa empresa);
    Task UpdateEmpresaAsync(Empresa empresa);
    Task DeleteEmpresaAsync(int id);
}