using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.Entities;
using RuesInfrastructure.Persistence;

namespace RuesInfrastructure.Repositories;

public class TipoDeOrganizacionRepository : ITipoDeOrganizacionRepository
{
    private readonly AppDbContext _context;

    public TipoDeOrganizacionRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<TipoDeOrganizacion>> ObtenerTipoDeOrganizacionAsync()
    {
        var tiposDeOrganizacion = await _context.TiposDeOrganizaciones.ToListAsync();
        return tiposDeOrganizacion;
    }

    public async Task<TipoDeOrganizacion> ObtenerTipoDeOrganizacionByIdAsync(int id)
    {
        var tipoDeOrganizacion = await _context.TiposDeOrganizaciones.FindAsync(id);
        return tipoDeOrganizacion;
    }

    public async Task AddTipoDeOrganizacionAsync(TipoDeOrganizacion tipoDeOrganizacion)
    {
        _context.Add(tipoDeOrganizacion);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTipoDeOrganizacionAsync(TipoDeOrganizacion tipoDeOrganizacion)
    {
        _context.Update(tipoDeOrganizacion);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTipoDeOrganizacionAsync(int id)
    {
        var  tipoDeOrganizacion = await _context.TiposDeOrganizaciones.FindAsync(id);
        if (tipoDeOrganizacion != null)
        {
            _context.Remove(tipoDeOrganizacion);
            await _context.SaveChangesAsync();
        }
    }
}