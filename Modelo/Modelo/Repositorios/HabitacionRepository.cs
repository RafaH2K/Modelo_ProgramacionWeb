using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.Modeloss;

namespace Modelo.Repositorios
{
    public class HabitacionRepository : IHabitacionRepository
    {
        private readonly ModeloDbContext _context;

        public HabitacionRepository(ModeloDbContext context)
        {
            _context = context;
        }

        public async Task<Habitacion> AddHabitacion(Habitacion habitacion)
        {
            await _context.Habitaciones.AddAsync(habitacion);
            await _context.SaveChangesAsync();
            return habitacion; // Devuelve la habitación añadida
        }

        public async Task<List<Habitacion>> GetAllHabitaciones()
        {
            return await _context.Habitaciones.ToListAsync();
        }

        public async Task<Habitacion> UpdateHabitacion(Habitacion habitacion)
        {
            _context.Habitaciones.Update(habitacion);
            await _context.SaveChangesAsync();
            return habitacion; // Devuelve la habitación actualizada
        }

        public async Task DeleteHabitacion(int id)
        {
            var habitacion = await _context.Habitaciones.FindAsync(id);
            if (habitacion != null)
            {
                _context.Habitaciones.Remove(habitacion);
                await _context.SaveChangesAsync();
            }
        }
    }
}