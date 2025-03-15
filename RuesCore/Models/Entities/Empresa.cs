namespace RuesCore.Models.Entities;

public class Empresa
{
    public int Id { get; set; }
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public CategoriaDeMatricula CategoriaDeMatricula { get; set; }
    public TipoDeSociedad TipoDeSociedad { get; set; }
    public TipoDeOrganizacion TipoDeOrganizacion { get; set; }
    public int NumeroDeMatricula { get; set; }
    public string CamaraDeComercio { get; set; }
    public DateTime FechaDeMatricula { get; set; }
    public DateTime? FechaDeCancelacion { get; set; }
    public EstadoMatricula EstadoMatricula { get; set; }
    public DateTime? FechaDeRenovacion { get; set; }
    public int? UltimoAñoRenovado { get; set; }
    public DateTime? FechaDeActualizacion { get; set; }
    public List<ActividadEconomica> ActividadesEconomicas { get; set; } = new List<ActividadEconomica>();
    public RepresentanteLegal RepresentanteLegal { get; set; }
}