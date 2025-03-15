using System.Text.Json.Serialization;

namespace RuesCore.Models.Entities;

public class ActividadEconomica
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Codigo { get; set; }
    [JsonIgnore]
    public List<Empresa> Empresas { get; set; } = new List<Empresa>();
}