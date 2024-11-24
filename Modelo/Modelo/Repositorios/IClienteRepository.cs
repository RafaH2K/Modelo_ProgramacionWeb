using Modelo.Modeloss;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public interface IClienteRepository
    {
        Task<Cliente?> Autenticar(string nombreUsuario, string contrasena); // Método para autenticar
        Task Add(Cliente cliente); // Método para agregar un cliente
        Task<bool> UsuarioExiste(string nombreUsuario); // Método para verificar si el usuario existe
    }
}