using Agendai.Domain.Entities;
using Agendai.Domain.Repositories;
using Agendai.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Agendai.Infra.Data.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        ApplicationDbContext _context;

        public AgendamentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Agendamento?> GetByIdAsync(Guid id)
        {
            return await _context.Agendamentos.FirstOrDefaultAsync(item => item.Id == id).ConfigureAwait(false);
        }
        public async Task<IEnumerable<Agendamento>> GetAllAsync()
        {
            return await _context.Agendamentos.ToListAsync().ConfigureAwait(false);
        }

        public async Task AddAsync(Agendamento agendamento)
        {
            _context.Add(agendamento);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task UpdateAsync(Agendamento agendamento)
        {
            _context.Update(agendamento);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task DeleteAsync(Guid agendamento)
        {
            _context.Remove(agendamento);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
