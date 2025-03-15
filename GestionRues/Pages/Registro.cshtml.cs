using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RuesCore.Models.Entities;
using RuesCore.Services;

namespace GestionRues.Pages;

public class Registro : PageModel
{
    private readonly EmpresaService _empresaService;
    private readonly TipoDocumentoService _tipoDocumentoService;
    private readonly CategoriaDeMatriculaService _categoriaDeMatriculaService;
    private readonly TipoDeSociedadService _tipoDeSociedadService;
    private readonly TipoDeOrganizacionService _tipoDeOrganizacionService;
    private readonly EstadoMatriculaService _estadoMatriculaService;

    public Registro(EmpresaService empresaService, 
        TipoDocumentoService tipoDocumentoService, 
        CategoriaDeMatriculaService categoriaDeMatriculaService, 
        TipoDeSociedadService tipoDeSociedadService,
        TipoDeOrganizacionService tipoDeOrganizacionService,
        EstadoMatriculaService estadoMatriculaService)
    {
        _empresaService = empresaService;
        _tipoDocumentoService = tipoDocumentoService;
        _categoriaDeMatriculaService = categoriaDeMatriculaService;
        _tipoDeSociedadService = tipoDeSociedadService;
        _tipoDeOrganizacionService = tipoDeOrganizacionService;
        _estadoMatriculaService = estadoMatriculaService;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        var empresas = await _empresaService.GetAllEmpresasAsync();
        return new JsonResult(empresas);
    }

    // Tipos de documento Uso del handler?
    public async Task<IActionResult> OnGetTiposDocumentosAsync()
    {
        var tiposDeDocumentos = await _tipoDocumentoService.GetTiposDeDocumentosAsync();
        return new JsonResult(tiposDeDocumentos);
    }

    public async Task<IActionResult> OnGetTipoDocumentoByIdAsync([FromQuery] int id)
    {
        var tipoDocumento = await _tipoDocumentoService.GetTipoDocumentoByIdAsync(id);
        return new JsonResult(tipoDocumento);
    }
    
    //Categoria de matricula
    public async Task<IActionResult> OnGetCategoriaDeMatriculaAsync()
    {
        var categoriasDeMatricula = await _categoriaDeMatriculaService.GetAllCategoriaDeMatriculaAsync();
        return new JsonResult(categoriasDeMatricula);
    }
    
    public async Task<IActionResult> OnGetCategoriaDeMatriculaByIdAsync([FromQuery] int id)
    {
        var categoriaDeMatricula = await _categoriaDeMatriculaService.GetCategoriaDeMatriculaByIdAsync(id);
        return new JsonResult(categoriaDeMatricula);
    }
    
    // Tipo de sociedad
    public async Task<IActionResult> OnGetTiposDeSociedadAsync()
    {
        var tiposDeSociedad = await _tipoDeSociedadService.GetAllTiposDeSociedadesAsync();
        return new JsonResult(tiposDeSociedad);
    }

    public async Task<IActionResult> OnGetTipoDeSociedadByIdAsync([FromQuery] int id)
    {
        var tipoDeSociedad = await _tipoDeSociedadService.GetTipoDeSociedadByIdAsync(id);
        return new JsonResult(tipoDeSociedad);
    }
    
    //Tipo de Organizacion
    public async Task<IActionResult> OnGetTiposDeOrganizacionAsync()
    {
        var tiposDeOrganizacion = await _tipoDeOrganizacionService.ObtenerTiposDeOrganizacionAsync();
        return new JsonResult(tiposDeOrganizacion);
    }

    public async Task<IActionResult> OnGetTipoDeOrganizacionByIdAsync([FromQuery] int id)
    {
        var tipoDeSociedad = await _tipoDeOrganizacionService.ObtenerTipoDeOrganizacionByIdAsync(id);
        return new JsonResult(tipoDeSociedad);
    }
    
    // Estados de matricula
    public async Task<IActionResult> OnGetEstadosMatriculaAsync()
    {
        var estadosMatricula = await _estadoMatriculaService.GetAllEstadosMatriculaAsync();
        return new JsonResult(estadosMatricula);
    }

    public async Task<IActionResult> OnGetEstadoMatriculaByIdAsync([FromQuery] int id)
    {
        var estadoMatricula = await _estadoMatriculaService.GetEstadoMatriculaByIdAsync(id);
        return new JsonResult(estadoMatricula);
    }
    
}