using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.Entities;
using RuesInfrastructure.Persistence;

namespace RuesInfrastructure.Repositories;

public class EstadoMatriculaRepository : IEstadoMatriculaRepository
{
    
    private readonly AppDbContext  _context;

    public EstadoMatriculaRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<EstadoMatricula>> ObtenerEstadosMatriculasAsync()
    {
        return await _context.EstadosMatriculas.ToListAsync();
    }

    public async Task<EstadoMatricula> ObtenerEstadoMatriculaByIdAsync(int id)
    {
        var  estadoMatricula = await _context.EstadosMatriculas.FindAsync(id);
        return estadoMatricula;
    }

    public async Task AddEstadoMatriculaAsync(EstadoMatricula estadoMatricula)
    {
        await _context.EstadosMatriculas.AddAsync(estadoMatricula);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateEstadoMatriculaAsync(EstadoMatricula estadoMatricula)
    {
        _context.EstadosMatriculas.Update(estadoMatricula);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEstadoMatriculaAsync(int id)
    {
        var estadoMatricula = ObtenerEstadoMatriculaByIdAsync(id);
        if (estadoMatricula != null)
        {
            _context.Remove(estadoMatricula);
            await _context.SaveChangesAsync();
        }
    }
}