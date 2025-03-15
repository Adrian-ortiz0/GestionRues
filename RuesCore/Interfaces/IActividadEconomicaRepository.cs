using RuesCore.Models.Entities;

namespace RuesCore.Interfaces;

public interface IActividadEconomicaRepository
{
    Task<IEnumerable<ActividadEconomica>> GetAllActividadEconomicaAsync();
    Task<ActividadEconomica> GetActividadEconomicaAsync(int id);
    Task AddActividadEconomicaAsync(ActividadEconomica actividadEconomica);
    Task UpdateActividadEconomicaAsync(ActividadEconomica actividadEconomica);
    Task DeleteActividadEconomicaAsync(int id);
}