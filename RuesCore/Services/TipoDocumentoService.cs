using RuesCore.Interfaces;
using RuesCore.Models.Entities;

namespace RuesCore.Services;

public class TipoDocumentoService
{
    private readonly ITipoDocumentoRespository  _tipoDocumentoRespository;

    public TipoDocumentoService(ITipoDocumentoRespository tipoDocumentoRespository)
    {
        _tipoDocumentoRespository = tipoDocumentoRespository;   
    }

    public async Task<IEnumerable<TipoDocumento>> GetTiposDeDocumentosAsync()
    {
        return await _tipoDocumentoRespository.GetAllTipoDocumentoAsync();
    }

    public async Task<TipoDocumento> GetTipoDocumentoByIdAsync(int id)
    {
        return await _tipoDocumentoRespository.GetTipoDocumentoByIdAsync(id);
    }

    public async Task AddTipoDocumentoAsync(TipoDocumento tipoDocumento)
    {
        await _tipoDocumentoRespository.AddTipoDocumentoAsync(tipoDocumento);
    }

    public async Task UpdateTipoDocumentoAsync(TipoDocumento tipoDocumento)
    {
        await _tipoDocumentoRespository.UpdateTipoDocumentoAsync(tipoDocumento);
    }

    public async Task DeleteTipoDocumentoAsync(int id)
    {
        await _tipoDocumentoRespository.DeleteTipoDocumentoAsync(id);
    }
}