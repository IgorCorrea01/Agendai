using Agendai.Domain.Entities;

namespace Agendai.Domain.Repositories
{
    public interface IEstabelecimentoRepository
    {
        Task<Estabelecimento> GetByIdAsync(Guid estabelecimentoId);
        Task AddAsync(Estabelecimento estabelecimento);
        Task UpdateAsync(Estabelecimento estabelecimento);
        Task DeleteAsync(Guid estabelecimentoId);
    }
}
