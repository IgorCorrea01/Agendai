using Agendai.Application.Contracts.Services;
using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;
using Agendai.Domain.Entities;
using Agendai.Domain.Repositories;
using AutoMapper;

namespace Agendai.Application.Services
{
    public sealed class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _agendamentoRepository;
        private readonly IMapper _mapper;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository, IMapper mapper)
        {
            _agendamentoRepository = agendamentoRepository;
            _mapper = mapper;
        }

        public async Task<AgendamentoResponse> GetByIdAsync(Guid agendamentoId)
        {
            var agendamento = await _agendamentoRepository.GetByIdAsync(agendamentoId);
            if (agendamento == null)
                throw new Exception("Agendamento não encontrado.");

            return _mapper.Map<AgendamentoResponse>(agendamento);
        }

        public async Task<IEnumerable<AgendamentoResponse>> GetAllAsync()
        {
            var agendamentos = await _agendamentoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<AgendamentoResponse>>(agendamentos);
        }

        public async Task AddAsync(AgendamentoRequest agendamentoRequest)
        {
            var agendamento = _mapper.Map<Agendamento>(agendamentoRequest);
            await _agendamentoRepository.AddAsync(agendamento);
        }

        public async Task UpdateAsync(AgendamentoRequest agendamentoRequest)
        {
            var agendamento = await _agendamentoRepository.GetByIdAsync(agendamentoRequest.AgendamentoId);
            if (agendamento == null)
                throw new Exception("Agendamento não encontrado.");

            _mapper.Map(agendamentoRequest, agendamento);

            await _agendamentoRepository.UpdateAsync(agendamento);
        }

        public async Task DeleteAsync(Guid agendamentoId)
        {
            var agendamento = await _agendamentoRepository.GetByIdAsync(agendamentoId);
            if (agendamento == null)
                throw new Exception("Agendamento não encontrado.");

            await _agendamentoRepository.DeleteAsync(agendamentoId);
        }
    }
}
