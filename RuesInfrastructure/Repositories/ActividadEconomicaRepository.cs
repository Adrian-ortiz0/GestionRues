using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.Entities;
using RuesInfrastructure.Persistence;

namespace RuesInfrastructure.Repositories;

public class ActividadEconomicaRepository :  IActividadEconomicaRepository
{
    
    private readonly AppDbContext  _context;

    public ActividadEconomicaRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<ActividadEconomica>> GetAllActividadEconomicaAsync()
    {
        return await _context.ActividadesEconomicas.ToListAsync();
    }

    public async Task<ActividadEconomica> GetActividadEconomicaAsync(int id)
    {
        return await _context.ActividadesEconomicas.FindAsync(id);
    }

    public async Task AddActividadEconomicaAsync(ActividadEconomica actividadEconomica)
    {
        await _context.ActividadesEconomicas.AddAsync(actividadEconomica);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateActividadEconomicaAsync(ActividadEconomica actividadEconomica)
    {
        _context.ActividadesEconomicas.Update(actividadEconomica);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteActividadEconomicaAsync(int id)
    {
        var actividadEconomica =  await _context.ActividadesEconomicas.FindAsync(id);
        if (actividadEconomica != null)
        {
            _context.ActividadesEconomicas.Remove(actividadEconomica);
            await _context.SaveChangesAsync();
        }
    }
}