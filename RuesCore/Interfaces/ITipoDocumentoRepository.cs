using RuesCore.Models.Entities;

namespace RuesCore.Interfaces;

public interface ITipoDocumentoRespository
{
    Task<IEnumerable<TipoDocumento>> GetAllTipoDocumentoAsync();
    Task<TipoDocumento> GetTipoDocumentoByIdAsync(int id);
    Task AddTipoDocumentoAsync(TipoDocumento tipoDocumento);
    Task UpdateTipoDocumentoAsync(TipoDocumento tipoDocumento);
    Task DeleteTipoDocumentoAsync(int id);
}