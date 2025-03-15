using RuesCore.Interfaces;
using RuesCore.Models.Entities;

namespace RuesCore.Services;

public class EstadoMatriculaService
{
    private readonly IEstadoMatriculaRepository  _estadoMatriculaRepository;

    public EstadoMatriculaService(IEstadoMatriculaRepository estadoMatriculaRepository)
    {
        _estadoMatriculaRepository = estadoMatriculaRepository;
    }

    public async Task<IEnumerable<EstadoMatricula>> GetAllEstadosMatriculaAsync()
    {
        return await _estadoMatriculaRepository.ObtenerEstadosMatriculasAsync();
    }

    public async Task<EstadoMatricula> GetEstadoMatriculaByIdAsync(int id)
    {
        return await _estadoMatriculaRepository.ObtenerEstadoMatriculaByIdAsync(id);
    }
}