using System.ComponentModel.DataAnnotations;

namespace Modelo.Modeloss
{
    public class Reserva : IValidatableObject
    {
        [Key]
        public int ReservaId { get; set; }

        [Required(ErrorMessage = "El Cliente es obligatorio.")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "La habitación es obligatoria.")]
        public int HabitacionId { get; set; }

        [Required(ErrorMessage = "La fecha de reserva es obligatoria.")]
        public DateTime FechaReserva { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha de fin es obligatoria.")]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "El estado de la reserva es obligatorio.")]
        public EstadoReserva EstadoReserva { get; set; } // Puedes definir un enum para los estados

        // Navegación hacia Cliente y Habitacion (opcional)
        public virtual Cliente Cliente { get; set; }
        public virtual Habitacion Habitacion { get; set; }

        // Validación personalizada
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FechaInicio >= FechaFin)
            {
                yield return new ValidationResult("La fecha de inicio debe ser anterior a la fecha de fin.", new[] { nameof(FechaInicio), nameof(FechaFin) });
            }
        }
    }

    // Enum para los estados de la reserva
    public enum EstadoReserva
    {
        Confirmada,
        Cancelada,
        Pendiente,
        Finalizada
    }
}
