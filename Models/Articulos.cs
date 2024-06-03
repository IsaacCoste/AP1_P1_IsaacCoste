using System.ComponentModel.DataAnnotations;

namespace AP1_P1_IsaacCoste.Models;
//articuloId, Descripcion, Costo, Ganancia y precio
public class Articulos
{
    [Key]
    public int ArticuloId { get; set; }
    [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚ\s]+$", ErrorMessage = "Solo se permiten letras")]
    public string Descripcion { get; set; }
    [Range(0.01, float.MaxValue, ErrorMessage = "El costo debe ser mayor a 0")]
    [Required(ErrorMessage ="Este campo es obligatorio.")]
    public decimal Costo { get; set; }
    [Range(0.01, float.MaxValue, ErrorMessage = "La ganancia debe ser mayor a 0")]
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public decimal Ganancia { get; set; }
    [Range(0.01, float.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public decimal Precio { get; set; }
}