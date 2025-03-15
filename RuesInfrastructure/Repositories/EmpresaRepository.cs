using Microsoft.EntityFrameworkCore;
using RuesCore.Interfaces;
using RuesCore.Models.Entities;
using RuesInfrastructure.Persistence;
namespace RuesInfrastructure.Repositories;

public class EmpresaRepository : IEmpresaRespository
{
    
    private readonly AppDbContext _context;

    public EmpresaRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Empresa>> GetAllEmpresasAsync()
    {
        return await _context.Empresas.ToListAsync();
    }

    public async Task<Empresa> GetEmpresaByIdAsync(int id)
    {
        var empresa = await _context.Empresas.FirstOrDefaultAsync(e => e.Id == id);
        return empresa;
    }

    public async Task AddEmpresaAsync(Empresa empresa)
    {
        _context.Empresas.Add(empresa);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateEmpresaAsync(Empresa empresa)
    {
        _context.Empresas.Update(empresa);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEmpresaAsync(int id)
    {
        var empresa = await _context.Empresas.FindAsync(id);
        if (empresa != null)
        {
            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();
        }
    }
}