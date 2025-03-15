using RuesCore.Models.Entities;

namespace RuesCore.Interfaces;

public interface IEstadoMatriculaRepository
{
    Task<IEnumerable<EstadoMatricula>> ObtenerEstadosMatriculasAsync();
    Task<EstadoMatricula> ObtenerEstadoMatriculaByIdAsync(int id);
    Task AddEstadoMatriculaAsync(EstadoMatricula estadoMatricula);
    Task UpdateEstadoMatriculaAsync(EstadoMatricula estadoMatricula);
    Task DeleteEstadoMatriculaAsync(int id);
}