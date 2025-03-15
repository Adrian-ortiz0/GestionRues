using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RuesCore.Models.DTOs;
using RuesCore.Models.Entities;
using RuesCore.Services;

namespace GestionRues.Pages;

public class Busqueda : PageModel
{
    private readonly EmpresaService _empresaService;
    private readonly TipoDocumentoService _tipoDocumentoService;
    private readonly CategoriaDeMatriculaService _categoriaDeMatriculaService;
    private readonly TipoDeSociedadService _tipoDeSociedadService;
    private readonly TipoDeOrganizacionService _tipoDeOrganizacionService;
    private readonly EstadoMatriculaService _estadoMatriculaService;
    private readonly ActividadEconomicaService _actividadEconomicaService;

    public Busqueda(EmpresaService empresaService, 
        TipoDocumentoService tipoDocumentoService, 
        CategoriaDeMatriculaService categoriaDeMatriculaService, 
        TipoDeSociedadService tipoDeSociedadService,
        TipoDeOrganizacionService tipoDeOrganizacionService,
        EstadoMatriculaService estadoMatriculaService,
        ActividadEconomicaService actividadEconomicaService)
    {
        _empresaService = empresaService;
        _tipoDocumentoService = tipoDocumentoService;
        _categoriaDeMatriculaService = categoriaDeMatriculaService;
        _tipoDeSociedadService = tipoDeSociedadService;
        _tipoDeOrganizacionService = tipoDeOrganizacionService;
        _estadoMatriculaService = estadoMatriculaService;
        _actividadEconomicaService = actividadEconomicaService;
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