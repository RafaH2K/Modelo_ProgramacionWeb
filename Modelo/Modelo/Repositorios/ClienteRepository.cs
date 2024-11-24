using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.Modeloss;

namespace Modelo.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ModeloDbContext _context; // Campo privado para el contexto

        public ClienteRepository(ModeloDbContext context) // Constructor que recibe el contexto
        {
            _context = context;
        }

        public async Task<Cliente?> Autenticar(string nombreUsuario, string contrasena)
        {
            return await _context.Clientes
                .FirstOrDefaultAsync(c => c.NombreUsuario == nombreUsuario && c.Contrasena == contrasena);
        }

        public async Task Add(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UsuarioExiste(string nombreUsuario)
        {
            return await _context.Clientes.AnyAsync(c => c.NombreUsuario == nombreUsuario);
        }
    }
}
