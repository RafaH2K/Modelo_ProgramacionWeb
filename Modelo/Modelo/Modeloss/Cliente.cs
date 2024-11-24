using System.ComponentModel.DataAnnotations;

namespace Modelo.Modeloss
{
    public class Cliente
    {
            [Key]
            public int ClienteId { get; set; }

            [Required(ErrorMessage = "El nombre es obligatorio.")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "Los apellidos son obligatorios.")]
            public string Apellidos { get; set; }

            [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
            public string Telefono { get; set; }

            [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
            [EmailAddress(ErrorMessage = "Se necesita un email válido.")]
            public string CorreoElectronico { get; set; }

            [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
            public string NombreUsuario { get; set; }

            [Required(ErrorMessage = "La contraseña es obligatoria.")]
            public string Contrasena { get; set; }

            public bool EsAdmin { get; set; } // Indica si el cliente es administrador
        }
    }
