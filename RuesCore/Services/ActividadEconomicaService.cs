using RuesCore.Interfaces;
using RuesCore.Models.Entities;

namespace RuesCore.Services;

public class ActividadEconomicaService
{
    private readonly IActividadEconomicaRepository  _actividadEconomicaRepository;

    public ActividadEconomicaService(IActividadEconomicaRepository actividadEconomicaRepository)
    {
        _actividadEconomicaRepository = actividadEconomicaRepository;
    }

    public async Task<IEnumerable<ActividadEconomica>> GetAllActividadEconomicaAsync()
    {
        return await _actividadEconomicaRepository.GetAllActividadEconomicaAsync();
    }

    public async Task<ActividadEconomica> GetActividadEconomicaByIdAsync(int id)
    {
        return await _actividadEconomicaRepository.GetActividadEconomicaAsync(id);
    }

    public async Task AddActividadEconomicaAsync(ActividadEconomica actividad)
    {
        await _actividadEconomicaRepository.AddActividadEconomicaAsync(actividad);
    }

    public async Task UpdateActividadEconomicaAsync(ActividadEconomica actividad)
    {
        await _actividadEconomicaRepository.UpdateActividadEconomicaAsync(actividad);
    }

    public async Task DeleteActividadEconomicaAsync(int id)
    {
        await _actividadEconomicaRepository.DeleteActividadEconomicaAsync(id);
    }
}