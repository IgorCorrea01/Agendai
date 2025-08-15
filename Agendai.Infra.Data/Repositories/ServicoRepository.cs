using Agendai.Domain.Entities;
using Agendai.Domain.Repositories;
using Agendai.Infra.Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Agendai.Infra.Data.Repositories
{
    public class ServicoRepository : IServicoRepository
    {
        ApplicationDbContext _context;

        public ServicoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Servico?> GetByIdAsync(Guid id)
        {
            return await _context.Servicos.FirstOrDefaultAsync(item => item.Id == id).ConfigureAwait(false);
        }
        public async Task<Servico?> GetByNameAsync(string nome)
        {
            return await _context.Servicos.FirstOrDefaultAsync(item => item.Nome == nome).ConfigureAwait(false);
        }
        public async Task<IEnumerable<Servico>> GetAllAsync()
        {
            return await _context.Servicos.ToListAsync().ConfigureAwait(false);
        }

        public async Task AddAsync(Servico servico)
        {
            _context.Add(servico);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task UpdateAsync(Servico servico)
        {
            _context.Update(servico);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task DeleteAsync(Guid servico)
        {
            _context.Remove(servico);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
