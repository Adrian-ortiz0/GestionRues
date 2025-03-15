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
    
    // GET: /Registro?handler=EmpresaById&id=1
    public async Task<IActionResult> OnGetEmpresaByIdAsync([FromQuery] int id)
    {
        var empresa = await _empresaService.GetEmpresaAsync(id);
        if (empresa == null)
        {
            return NotFound();
        }
        return new JsonResult(empresa);
    }
    
    public async Task<IActionResult> OnPostAddEmpresaConRepresentanteAsync([FromBody] EmpresaConRepresentanteLegalDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _empresaService.AddEmpresaConRepresentanteAsync(dto);
        return new JsonResult(new { message = "Empresa y representante registrados correctamente" });
    }
    
    // POST: /Registro?handler=UpdateEmpresa
    // Simula un PUT para actualizar. Recibe el objeto Empresa en el body.
    public async Task<IActionResult> OnPostUpdateEmpresaAsync([FromBody] Empresa empresa)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        await _empresaService.UpdateEmpresaAsync(empresa);
        return new JsonResult(new { message = "Empresa actualizada correctamente" });
    }

    // POST: /Registro?handler=DeleteEmpresa&id=1
    // Simula un DELETE usando POST y enviando el id por query string.
    public async Task<IActionResult> OnPostDeleteEmpresaAsync([FromQuery] int id)
    {
        await _empresaService.DeleteEmpresaAsync(id);
        return new JsonResult(new { message = "Empresa eliminada correctamente" });
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
    
    // Actividades economicas
    public async Task<IActionResult> OnGetActividadesEconomicasAsync()
    {
        var actividadesEconomicas = await _actividadEconomicaService.GetAllActividadEconomicaAsync();
        return new JsonResult(actividadesEconomicas);
    }

    public async Task<IActionResult> OnGetActividadEconomicaByIdAsync([FromQuery] int id)
    {
        var actividadEconomica = await _actividadEconomicaService.GetActividadEconomicaByIdAsync(id);
        return new JsonResult(actividadEconomica);
    }
}