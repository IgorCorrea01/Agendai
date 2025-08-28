using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;

namespace Agendai.Application.Contracts.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioResponse> LoginAsync(LoginRequest loginRequest);
        Task<UsuarioResponse> GetByEmailAsync(string email);
        Task<UsuarioResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<UsuarioResponse>> GetAllAsync();
        Task AddAsync(RegistroRequest usuario);
        Task UpdateAsync(Guid id, RegistroRequest usuario);
        Task DeleteAsync(Guid id);
    }
}
