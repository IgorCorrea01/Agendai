namespace Agendai.Application.Contracts.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioResponse> LoginAsync(LoginRequest loginRequest);
        Task<UsuarioResponse> GetByEmailAsync(string email);
        Task<UsuarioResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<UsuarioResponse>> GetAllAsync();
        Task AddAsync(RegistroRequest usuario);
        Task UpdateAsync(RegistroRequest usuario);
        Task DeleteAsync(Guid id);
    }
}