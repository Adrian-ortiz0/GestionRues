using RuesCore.Interfaces;
using RuesCore.Models.Entities;

namespace RuesCore.Services;

public class CategoriaDeMatriculaService
{
    private readonly ICategoriaDeMatriculaRepository  _categoriaDeMatriculaRepository;

    public CategoriaDeMatriculaService(ICategoriaDeMatriculaRepository categoriaDeMatriculaRepository)
    {
        _categoriaDeMatriculaRepository = categoriaDeMatriculaRepository;
    }

    public async Task<IEnumerable<CategoriaDeMatricula>> GetAllCategoriaDeMatriculaAsync()
    {
        return await _categoriaDeMatriculaRepository.GetAllCategoriaDeMatriculaAsync();
    }

    public async Task<CategoriaDeMatricula> GetCategoriaDeMatriculaByIdAsync(int id)
    {
        return await _categoriaDeMatriculaRepository.GetCategoriaDeMatriculaByIdAsync(id);
    }

    public async Task AddCategoriaDeMatriculaAsync(CategoriaDeMatricula categoria)
    {
        await _categoriaDeMatriculaRepository.AddCategoriaDeMatriculaAsync(categoria);
    }

    public async Task UpdateCategoriaDeMatriculaAsync(CategoriaDeMatricula categoria)
    {
        await _categoriaDeMatriculaRepository.UpdateCategoriaDeMatriculaAsync(categoria);
    }

    public async Task DeleteCategoriaDeMatriculaAsync(int id)
    {
        await _categoriaDeMatriculaRepository.DeleteCategoriaDeMatriculaAsync(id);
    }
}