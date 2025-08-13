using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendai.Application.Services
{
    public class UsuarioService
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
