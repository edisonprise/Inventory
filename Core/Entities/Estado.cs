
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Estado
{
    [Key]
    public string? codEstado { get; set; }

    public string? nombreEstado { get; set; }
}
