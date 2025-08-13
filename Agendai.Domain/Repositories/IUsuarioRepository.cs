using Agendai.Domain.Entities;

namespace Agendai.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetByEmailAsync(string email);
        Task<Usuario> GetByIdAsync(Guid email);
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task AddAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(Usuario usuarioId);
    }
}
