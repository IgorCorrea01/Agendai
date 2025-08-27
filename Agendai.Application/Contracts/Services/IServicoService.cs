using Agendai.Application.DTOs.Request;

namespace Agendai.Application.Contracts.Services
{
    public interface IServicoService
    {
        Task<ServicoRequest> GetByIdAsync(Guid servicoId);
        Task<ServicoRequest> GetByNameAsync(string servico);
        Task<IEnumerable<ServicoRequest>> GetAllAsync();
        Task AddAsync(ServicoRequest servico);
        Task UpdateAsync(ServicoRequest servico);
        Task DeleteAsync(Guid servicoId);
    }
}
