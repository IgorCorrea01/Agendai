using Agendai.Domain.Entities;

namespace Agendai.Application.Contracts.Services
{
    public interface IJwtService
    {
        public string GenerateToken(Usuario usuario);
    }
}
