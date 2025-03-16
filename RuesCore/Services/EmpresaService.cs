using RuesCore.Interfaces;
using RuesCore.Models.DTOs;
using RuesCore.Models.Entities;

namespace RuesCore.Services;

public class EmpresaService
{
    private readonly IEmpresaRespository _empresaRepository;
    private readonly ICategoriaDeMatriculaRepository _categoriaDeMatriculaRepository;
    private readonly ITipoDeSociedadRepository _tipoDeSociedadRepository;
    private readonly ITipoDeOrganizacionRepository _tipoDeOrganizacionRepository;
    private readonly IEstadoMatriculaRepository _estadoMatriculaRepository;
    private readonly ITipoDocumentoRespository _tipoDocumentoRepository;
    private readonly IActividadEconomicaRepository _actividadEconomicaRepository;

    public EmpresaService(IEmpresaRespository empresaRepository,
        ICategoriaDeMatriculaRepository categoriaDeMatriculaRepository,
        ITipoDeSociedadRepository tipoDeSociedadRepository,
        ITipoDeOrganizacionRepository tipoDeOrganizacionRepository,
        IEstadoMatriculaRepository estadoMatriculaRepository,
        ITipoDocumentoRespository tipoDocumentoRepository,
        IActividadEconomicaRepository actividadEconomicaRepository)
    {
        _empresaRepository = empresaRepository;
        _categoriaDeMatriculaRepository = categoriaDeMatriculaRepository;
        _tipoDeSociedadRepository = tipoDeSociedadRepository;
        _tipoDeOrganizacionRepository = tipoDeOrganizacionRepository;
        _estadoMatriculaRepository = estadoMatriculaRepository;
        _tipoDocumentoRepository = tipoDocumentoRepository;
        _actividadEconomicaRepository = actividadEconomicaRepository;
    }

    public async Task<Empresa> GetEmpresaAsync(int id)
    {
        return await _empresaRepository.GetEmpresaByIdAsync(id);
    }

    public async Task<IEnumerable<Empresa>> GetAllEmpresasAsync()
    {
        return await _empresaRepository.GetAllEmpresasAsync();
    }

    public async Task<IEnumerable<EmpresaResponseDto>> GetAllEmpresasResponseAsync()
    {
        return await _empresaRepository.GetAllEmpresasResponseAsync();
    }

    public async Task<EmpresaResponseDto> GetEmpresaResponseByNombreAsync(string nombre)
    {
        return await _empresaRepository.GetEmpresaResponseByNombreAsync(nombre);
    }

    public async Task UpdateEmpresaResponseAsync(UpdateEmpresaDto dto)
    {
        var empresa = await _empresaRepository.GetEmpresaByIdAsync(dto.Id);
        
        if (empresa == null)
            throw new KeyNotFoundException("Empresa no encontrada");
        
        await _empresaRepository.UpdateEmpresaResponseAsync(empresa, dto);
    }

public async Task AddEmpresaConRepresentanteAsync(EmpresaConRepresentanteLegalDto dto)
    {
    
    var categoria = await _categoriaDeMatriculaRepository.GetCategoriaDeMatriculaByIdAsync(dto.CategoriaMatriculaId);
    var tipoSociedad = await _tipoDeSociedadRepository.GetTipoDeSociedadByIdAsync(dto.TipoDeSociedadId);
    var tipoOrganizacion = await _tipoDeOrganizacionRepository.ObtenerTipoDeOrganizacionByIdAsync(dto.TipoDeOrganizacionId);
    var estadoMatricula = await _estadoMatriculaRepository.ObtenerEstadoMatriculaByIdAsync(dto.EstadoMatriculaId);
    var actividades = new List<ActividadEconomica>();
    
    foreach (var actividadId in dto.ActividadesEconomicas)
    {
         var actividad = await _actividadEconomicaRepository.GetActividadEconomicaAsync(actividadId);
         if (actividad != null)
             actividades.Add(actividad);
    }
    var tipoDocumento = await _tipoDocumentoRepository.GetTipoDocumentoByIdAsync(dto.RepresentanteLegal.TipoDocumentoId);

    var representante = new RepresentanteLegal
    {
        Nombre = dto.RepresentanteLegal.Nombre,
        Apellido = dto.RepresentanteLegal.Apellido,
        TipoDocumento = tipoDocumento,
        Documento = dto.RepresentanteLegal.Documento,
        Telefono = dto.RepresentanteLegal.Telefono,
        Correo = dto.RepresentanteLegal.Correo,
        CargoDeLaEmpresa = dto.RepresentanteLegal.CargoDeLaEmpresa,
        FechaDeNombramiento = dto.RepresentanteLegal.FechaDeNombramiento
    };

    var empresa = new Empresa
    {
        Identificacion = dto.Identificacion,
        Nombre = dto.Nombre,
        CategoriaDeMatricula = categoria,
        TipoDeSociedad = tipoSociedad,
        TipoDeOrganizacion = tipoOrganizacion,
        NumeroDeMatricula = dto.NumeroDeMatricula,
        CamaraDeComercio = dto.CamaraDeComercio,
        FechaDeMatricula = dto.FechaDeMatricula,
        EstadoMatricula = estadoMatricula,
        ActividadesEconomicas = actividades,
        RepresentanteLegal = representante
    };

    await _empresaRepository.AddEmpresaAsync(empresa);
}

    public async Task DeleteEmpresaAsync(int id)
    {
        await _empresaRepository.DeleteEmpresaAsync(id);
    }
}