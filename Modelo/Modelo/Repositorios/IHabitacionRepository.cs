using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo.Modeloss;

namespace Modelo.Repositorios
{
    public interface IHabitacionRepository
    {
        Task<Habitacion> AddHabitacion(Habitacion habitacion); // Método para agregar una habitación
        Task<List<Habitacion>> GetAllHabitaciones(); // Método para obtener todas las habitaciones
        Task<Habitacion> UpdateHabitacion(Habitacion habitacion); // Método para actualizar una habitación
        Task DeleteHabitacion(int id); // Método para eliminar una habitación
    }
}
