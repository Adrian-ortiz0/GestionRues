using RuesCore.Models.Entities;

namespace RuesCore.Interfaces;

public interface ITipoDeOrganizacionRepository
{
    Task<IEnumerable<TipoDeOrganizacion>> ObtenerTipoDeOrganizacionAsync();
    Task<TipoDeOrganizacion> ObtenerTipoDeOrganizacionByIdAsync(int id);
    Task AddTipoDeOrganizacionAsync(TipoDeOrganizacion tipoDeOrganizacion);
    Task UpdateTipoDeOrganizacionAsync(TipoDeOrganizacion tipoDeOrganizacion);
    Task DeleteTipoDeOrganizacionAsync(int id);
}