namespace RuesCore.Models.Entities;

public class ActividadEconomica
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Codigo { get; set; }
    public List<Empresa> Empresas { get; set; } = new List<Empresa>();
}