using System.ComponentModel.DataAnnotations;

namespace MiApiRest.Models;

public class Producto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres.")]
    public string Nombre { get; set; } = string.Empty;

    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un valor no negativo.")]
    public decimal Precio { get; set; }

    public bool Disponible { get; set; } = true;
}
