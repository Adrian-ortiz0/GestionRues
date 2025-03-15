using RuesCore.Interfaces;
using RuesCore.Models.Entities;

namespace RuesCore.Services;

public class TipoDeSociedadService
{
    private readonly ITipoDeSociedadRepository  _tipoDeSociedadRepository;

    public TipoDeSociedadService(ITipoDeSociedadRepository tipoDeSociedadRepository)
    {
        _tipoDeSociedadRepository = tipoDeSociedadRepository;
    }

    public async Task<IEnumerable<TipoDeSociedad>> GetAllTiposDeSociedadesAsync()
    {
        return await _tipoDeSociedadRepository.GetAllTiposDeSociedadAsync();
    }

    public async Task<TipoDeSociedad> GetTipoDeSociedadByIdAsync(int id)
    {
        return await _tipoDeSociedadRepository.GetTipoDeSociedadByIdAsync(id);
    }

    public async Task AddTipoDeSociedadAsync(TipoDeSociedad tipoDeSociedad)
    {
        await _tipoDeSociedadRepository.AddTipoDeSociedadAsync(tipoDeSociedad);
    }
    
    public async Task UpdateTipoDeSociedadAsync(TipoDeSociedad tipoDeSociedad)
    {
        await _tipoDeSociedadRepository.UpdateTipoDeSociedadAsync(tipoDeSociedad);
    }

    public async Task DeleteTipoDeSociedadAsync(int id)
    {
        await _tipoDeSociedadRepository.DeleteTipoDeSociedadAsync(id);
    }
}