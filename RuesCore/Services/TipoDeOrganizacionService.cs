using RuesCore.Interfaces;
using RuesCore.Models.Entities;

namespace RuesCore.Services;

public class TipoDeOrganizacionService
{
    private readonly ITipoDeOrganizacionRepository _tipoDeOrganizacionRepository;

    public TipoDeOrganizacionService(ITipoDeOrganizacionRepository repository)
    {
        _tipoDeOrganizacionRepository = repository;
    }

    public async Task<IEnumerable<TipoDeOrganizacion>> ObtenerTiposDeOrganizacionAsync()
    {
        return await _tipoDeOrganizacionRepository.ObtenerTipoDeOrganizacionAsync();
    }

    public async Task<TipoDeOrganizacion> ObtenerTipoDeOrganizacionByIdAsync(int id)
    {
        return await _tipoDeOrganizacionRepository.ObtenerTipoDeOrganizacionByIdAsync(id);
    }

    public async Task AddTipoDeOrganizacionAsync(TipoDeOrganizacion tipoDeOrganizacion)
    {
        await _tipoDeOrganizacionRepository.ObtenerTipoDeOrganizacionAsync();
    }
    public async Task UpdateTipoDeOrganizacionAsync(TipoDeOrganizacion tipoDeOrganizacion)
    {
        await _tipoDeOrganizacionRepository.UpdateTipoDeOrganizacionAsync(tipoDeOrganizacion);
    }

    public async Task DeleteTipoDeOrganizacionAsync(int id)
    {
        await _tipoDeOrganizacionRepository.DeleteTipoDeOrganizacionAsync(id);
    }
}