using Agendai.Domain.Entities;

namespace Agendai.Domain.Repositories
{
    public interface IAgendamentoRepository
    {
        Task<Agendamento> GetByIdAsync(Guid agendamentoId);
        Task<IEnumerable<Agendamento>> GetAllAsync();
        Task AddAsync(Agendamento agendamento);
        Task UpdateAsync(Agendamento agendamento);
        Task DeleteAsync(Guid agendamentoId);
    }
}
