namespace RuesCore.Models.DTOs;

public class EmpresaConRepresentanteLegalDto
{
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public int CategoriaMatriculaId { get; set; }
    public int TipoDeSociedadId { get; set; }
    public int TipoDeOrganizacionId { get; set; }
    public int NumeroDeMatricula { get; set; }
    public string CamaraDeComercio { get; set; }
    public DateTime FechaDeMatricula { get; set; }
    public int EstadoMatriculaId { get; set; }
    public List<int> ActividadesEconomicas { get; set; }
    public RepresentanteLegalDto RepresentanteLegal { get; set; }
}