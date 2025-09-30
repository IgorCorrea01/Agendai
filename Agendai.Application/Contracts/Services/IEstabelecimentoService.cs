using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;

namespace Agendai.Application.Contracts.Services
{
    public interface IEstabelecimentoService
    {
        Task<EstabelecimentoResponse> GetByIdAsync(Guid estabelecimentoId);
        Task AddAsync(EstabelecimentoRequest estabelecimento);
        Task UpdateAsync(Guid id, EstabelecimentoRequest estabelecimento);
        Task DeleteAsync(Guid estabelecimentoId);
    }
}
