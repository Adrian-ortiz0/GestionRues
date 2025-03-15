using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RuesCore.Models.DTOs;
using RuesCore.Models.Entities;
using RuesCore.Services;

namespace GestionRues.Pages;

public class Busqueda : PageModel
{
    private readonly EmpresaService _empresaService;


    public Busqueda(EmpresaService empresaService)
    {
        _empresaService = empresaService;

    }

    public async Task<IActionResult> OnGetEmpresasAsync()
    {
        var empresas = await _empresaService.GetAllEmpresasAsync();
        return new JsonResult(empresas);
    }
    
    public async Task<IActionResult> OnGetEmpresasResponseAsync()
    {
        var empresas = await _empresaService.GetAllEmpresasResponseAsync();
        return new JsonResult(empresas);
    }
    
    public async Task<IActionResult> OnGetEmpresaByNombreAsync([FromQuery] string nombre)
    {
        var empresaDto = await _empresaService.GetEmpresaResponseByNombreAsync(nombre);
        if (empresaDto == null)
        {
            return NotFound();
        }
        return new JsonResult(empresaDto);
    }
}