
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Pais
{
    [Key]
    public string codPais { get; set; }
    public string nombrePais { get; set; }
    public IList<Estado> Estados { get; set; }
}
