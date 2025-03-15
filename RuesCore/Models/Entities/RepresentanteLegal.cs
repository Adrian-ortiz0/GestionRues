namespace RuesCore.Models.Entities;

public class RepresentanteLegal
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public TipoDocumento TipoDocumento { get; set; }
    public string Documento { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string CargoDeLaEmpresa { get; set; }
    public DateTime FechaDeNombramiento { get; set; }
    public List<Empresa> Empresas { get; set; }
}