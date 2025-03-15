using RuesCore.Models.Entities;

namespace RuesCore.Interfaces;

public interface ICategoriaDeMatriculaRepository
{
    Task<IEnumerable<CategoriaDeMatricula>> GetAllCategoriaDeMatriculaAsync();
    Task<CategoriaDeMatricula> GetCategoriaDeMatriculaByIdAsync(int id);
    Task AddCategoriaDeMatriculaAsync(CategoriaDeMatricula categoriaDeMatricula);
    Task UpdateCategoriaDeMatriculaAsync(CategoriaDeMatricula categoriaDeMatricula);
    Task DeleteCategoriaDeMatriculaAsync(int id);
}