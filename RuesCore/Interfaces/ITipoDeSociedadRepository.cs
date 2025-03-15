using RuesCore.Models.Entities;

namespace RuesCore.Interfaces;

public interface ITipoDeSociedadRepository
{
    Task<IEnumerable<TipoDeSociedad>> GetAllTiposDeSociedadAsync();
    Task<TipoDeSociedad> GetTipoDeSociedadByIdAsync(int id);
    Task AddTipoDeSociedadAsync(TipoDeSociedad tipoDeSociedad);
    Task UpdateTipoDeSociedadAsync(TipoDeSociedad tipoDeSociedad);
    Task DeleteTipoDeSociedadAsync(int id);
}