using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.Entities;
using RuesInfrastructure.Persistence;

namespace RuesInfrastructure.Repositories;

public class CategoriaDeMatriculaRepository : ICategoriaDeMatriculaRepository
{
    
    private readonly AppDbContext  _context;

    public CategoriaDeMatriculaRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<CategoriaDeMatricula>> GetAllCategoriaDeMatriculaAsync()
    {
        var categoriasDeMatricula = _context.CategoriasDeMatriculas.ToListAsync();
        return await categoriasDeMatricula;
    }

    public async Task<CategoriaDeMatricula> GetCategoriaDeMatriculaByIdAsync(int id)
    {
        var categoriaDeMatricula = await _context.CategoriasDeMatriculas
            .FirstOrDefaultAsync(tm => tm.Id == id);
        return categoriaDeMatricula;
    }

    public Task AddCategoriaDeMatriculaAsync(CategoriaDeMatricula categoriaDeMatricula)
    {
        _context.CategoriasDeMatriculas.Add(categoriaDeMatricula);
        return _context.SaveChangesAsync();
    }

    public Task UpdateCategoriaDeMatriculaAsync(CategoriaDeMatricula categoriaDeMatricula)
    {
        _context.CategoriasDeMatriculas.Update(categoriaDeMatricula);
        return _context.SaveChangesAsync();
    }

    public async Task DeleteCategoriaDeMatriculaAsync(int id)
    {
        var categoriaDeMatricula = await _context.CategoriasDeMatriculas.FindAsync(id);
        if (categoriaDeMatricula != null)
        {
            _context.CategoriasDeMatriculas.Remove(categoriaDeMatricula);
            await _context.SaveChangesAsync();
        }
    }
}