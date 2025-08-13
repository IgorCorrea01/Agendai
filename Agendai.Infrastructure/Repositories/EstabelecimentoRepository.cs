using Agendai.Domain.Entities;
using Agendai.Domain.Repositories;
using Agendai.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Agendai.Infra.Data.Repositories
{
    public class EstabelecimentoRepository : IEstabelecimentoRepository
    {
        ApplicationDbContext _context;

        public EstabelecimentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Estabelecimento?> GetByIdAsync(Guid id)
        {
            return await _context.Estabelecimentos.FirstOrDefaultAsync(item => item.Id == id).ConfigureAwait(false);
        }

        public async Task AddAsync(Estabelecimento estabelecimento)
        {
            _context.Add(estabelecimento);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task UpdateAsync(Estabelecimento estabelecimento)
        {
            _context.Update(estabelecimento);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task DeleteAsync(Guid estabelecimento)
        {
            _context.Remove(estabelecimento);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
