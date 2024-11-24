using System.ComponentModel.DataAnnotations;

namespace Modelo.Modeloss
{
    public class Habitacion
    {
        [Key]
        public int HabitacionId { get; set; }

        [Required(ErrorMessage = "El número de habitación es obligatorio.")]
        public string NumeroHabitacion { get; set; }

        [Required(ErrorMessage = "El tipo de habitación es obligatorio.")]
        public string TipoHabitacion { get; set; }

        [Required(ErrorMessage = "El precio por noche es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un número positivo.")]
        public decimal PrecioPorNoche { get; set; }

        [Required(ErrorMessage = "El estado de la habitación es obligatorio.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion { get; set; }

        public bool Disponible { get; set; } // Indica si la habitación está disponible

        // Nueva propiedad para la URL de la imagen
        [Url(ErrorMessage = "La URL de la imagen no es válida.")]
        public string ImagenUrl { get; set; }
    }
}
