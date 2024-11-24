using Microsoft.EntityFrameworkCore;
using Modelo.Modeloss;

namespace Modelo.Modeloss
{
    public class ModeloDbContext : DbContext
    {
        public ModeloDbContext(DbContextOptions<ModeloDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar el índice único para el correo electrónico
            modelBuilder.Entity<Cliente>()
                .HasIndex(c => c.CorreoElectronico)
                .IsUnique();

            // Configurar el tipo de dato para el precio por noche
            modelBuilder.Entity<Habitacion>()
                .Property(h => h.PrecioPorNoche)
                .HasColumnType("decimal(18,2)");

            // Otras configuraciones pueden ir aquí...
        }
    }
}