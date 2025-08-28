using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;

namespace Agendai.Application.Contracts.Services
{
    public interface IServicoService
    {
        Task<ServicoResponse> GetByIdAsync(Guid servicoId);
        Task<ServicoResponse> GetByNameAsync(string servico);
        Task<IEnumerable<ServicoResponse>> GetAllAsync();
        Task AddAsync(ServicoRequest servico);
        Task UpdateAsync(Guid id, ServicoRequest servico);
        Task DeleteAsync(Guid servicoId);
    }
}
