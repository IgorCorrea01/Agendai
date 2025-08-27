using Agendai.Application.DTOs.Request;

namespace Agendai.Application.Contracts.Services
{
    public interface IAgendamentoService
    {
        Task<AgendamentoRequest> GetByIdAsync(Guid agendamentoId);
        Task<IEnumerable<AgendamentoRequest>> GetAllAsync();
        Task AddAsync(AgendamentoRequest agendamento);
        Task UpdateAsync(AgendamentoRequest agendamento);
        Task DeleteAsync(Guid agendamentoId);
    }
}
