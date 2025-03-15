namespace RuesCore.Models.DTOs;

public class EmpresaResponseDto
{
    public int Id { get; set; }
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public string CategoriaDeMatricula { get; set; }
    public string TipoDeSociedad { get; set; }
    public string TipoDeOrganizacion { get; set; } 
    public int NumeroDeMatricula { get; set; }
    public string CamaraDeComercio { get; set; }
    public DateTime FechaDeMatricula { get; set; }
    public string EstadoMatricula { get; set; }
    public string? FechaDeRenovacion { get; set; }
    public string? UltimoAñoRenovado { get; set; }
    public string? FechaDeActualizacion { get; set; }
    public List<string> ActividadesEconomicas { get; set; }
    public List<string> CodigoActividadesEconomicas { get; set; }
    public string RepresentanteLegal { get; set; }
    public string RepresentanteLegalDocumento { get; set; }
}   