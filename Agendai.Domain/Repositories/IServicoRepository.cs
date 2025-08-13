using Agendai.Domain.Entities;

namespace Agendai.Domain.Repositories
{
    public interface IServicoRepository
    {
        Task<Servico> GetByIdAsync(Guid servicoId);
        Task<Servico> GetByNameAsync(string servico);
        Task<IEnumerable<Servico>> GetAllAsync();
        Task AddAsync(Servico servico);
        Task UpdateAsync(Servico servico);
        Task DeleteAsync(Guid servicoId);
    }
}
