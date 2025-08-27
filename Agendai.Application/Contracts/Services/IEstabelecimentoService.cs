using Agendai.Application.DTOs.Request;

namespace Agendai.Application.Contracts.Services
{
    public interface IEstabelecimentoService
    {
        Task<EstabelecimentoRequest> GetByIdAsync(Guid estabelecimentoId);
        Task AddAsync(EstabelecimentoRequest estabelecimento);
        Task UpdateAsync(EstabelecimentoRequest estabelecimento);
        Task DeleteAsync(Guid estabelecimentoId);
    }
}
