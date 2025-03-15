using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.Entities;
using RuesInfrastructure.Persistence;

namespace RuesInfrastructure.Repositories;

public class TipoDocumentoRepository : ITipoDocumentoRespository
{
    
    private readonly AppDbContext  _context;

    public TipoDocumentoRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<TipoDocumento>> GetAllTipoDocumentoAsync()
    {
        var tiposDeDocumentos = await  _context.TiposDeDocumentos.ToListAsync();
        return tiposDeDocumentos;
    }

    public async Task<TipoDocumento> GetTipoDocumentoByIdAsync(int id)
    {
        var tipoDocumento = await _context.TiposDeDocumentos.FirstOrDefaultAsync(td => td.Id == id);
        return tipoDocumento;
    }

    public Task AddTipoDocumentoAsync(TipoDocumento tipoDocumento)
    {
        _context.TiposDeDocumentos.Add(tipoDocumento);
        return _context.SaveChangesAsync();
    }

    public Task UpdateTipoDocumentoAsync(TipoDocumento tipoDocumento)
    {
        _context.TiposDeDocumentos.Update(tipoDocumento);
        return _context.SaveChangesAsync();
    }

    public async Task DeleteTipoDocumentoAsync(int id)
    {
        var tipoDocumento = await _context.TiposDeDocumentos.FindAsync(id);
        if (tipoDocumento != null)
        {
            _context.TiposDeDocumentos.Remove(tipoDocumento);
            await _context.SaveChangesAsync();
        }
    }
}