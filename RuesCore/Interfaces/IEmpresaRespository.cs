using RuesCore.Models.DTOs;
using RuesCore.Models.Entities;

namespace RuesCore.Interfaces;

public interface IEmpresaRespository
{
    Task<IEnumerable<Empresa>> GetAllEmpresasAsync();
    Task<IEnumerable<EmpresaResponseDto>> GetAllEmpresasResponseAsync();
    Task<Empresa> GetEmpresaByIdAsync(int id);
    Task AddEmpresaAsync(Empresa empresa);
    Task DeleteEmpresaAsync(int id);
    Task<EmpresaResponseDto> GetEmpresaResponseByNombreAsync(string nombre);
    Task UpdateEmpresaResponseAsync(Empresa empresa, UpdateEmpresaDto dto);
}