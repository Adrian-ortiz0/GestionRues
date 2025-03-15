using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.Entities;
using RuesInfrastructure.Persistence;

namespace RuesInfrastructure.Repositories;

public class TipoDeSociedadRepository : ITipoDeSociedadRepository
{
    private readonly AppDbContext  _context;

    public TipoDeSociedadRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<TipoDeSociedad>> GetAllTiposDeSociedadAsync()
    {
        var tiposDeSociedad = await _context.TiposDeSociedades.ToListAsync();
        return tiposDeSociedad;
    }

    public async Task<TipoDeSociedad> GetTipoDeSociedadByIdAsync(int id)
    {
        var  tipoDeSociedad = await _context.TiposDeSociedades.FirstOrDefaultAsync(t => t.Id == id);
        return tipoDeSociedad;
    }

    public Task AddTipoDeSociedadAsync(TipoDeSociedad tipoDeSociedad)
    {
        _context.TiposDeSociedades.Add(tipoDeSociedad);
        return _context.SaveChangesAsync();
    }

    public Task UpdateTipoDeSociedadAsync(TipoDeSociedad tipoDeSociedad)
    {
        _context.TiposDeSociedades.Update(tipoDeSociedad);
        return _context.SaveChangesAsync();
    }

    public async Task DeleteTipoDeSociedadAsync(int id)
    {
        var tipoDeSociedad = _context.TiposDeSociedades.FirstOrDefault(t => t.Id == id);
        if (tipoDeSociedad != null)
        {
            _context.TiposDeSociedades.Remove(tipoDeSociedad);
            await _context.SaveChangesAsync();
        }
    }
}