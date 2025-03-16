namespace RuesCore.Models.DTOs;

public class UpdateEmpresaDto
{
    public int Id { get; set; }
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public int CategoriaMatriculaId { get; set; }
    public int TipoDeSociedadId { get; set; }
    public int TipoDeOrganizacionId  { get; set; }
    public string NumeroDeMatricula { get; set; }
    public string CamaraDeComercio { get; set; }
    public DateTime FechaDeRenovacion { get; set; }
    public DateTime FechaDeActualizacion { get; set; }
    public string UltimoAñoDeActualizacion { get; set; }
    public int EstadoMatriculaId { get; set; }
    public List<int> ActividadesComercialesId { get; set; }

}