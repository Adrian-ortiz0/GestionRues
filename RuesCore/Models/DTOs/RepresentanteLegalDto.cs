namespace RuesCore.Models.DTOs;

public class RepresentanteLegalDto
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int TipoDocumentoId { get; set; }
    public string Documento { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string CargoDeLaEmpresa { get; set; }
    public DateTime FechaDeNombramiento { get; set; }
}