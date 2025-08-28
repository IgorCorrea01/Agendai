using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;

namespace Agendai.Application.Contracts.Services
{
    public interface IAgendamentoService
    {
        Task<AgendamentoResponse> GetByIdAsync(Guid agendamentoId);
        Task<IEnumerable<AgendamentoResponse>> GetAllAsync();
        Task AddAsync(AgendamentoRequest agendamento);
        Task UpdateAsync(Guid id, AgendamentoRequest agendamento);
        Task DeleteAsync(Guid agendamentoId);
    }
}
