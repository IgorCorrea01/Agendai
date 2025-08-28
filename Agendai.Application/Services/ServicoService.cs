using Agendai.Application.Contracts.Services;
using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;
using Agendai.Domain.Entities;
using Agendai.Domain.Repositories;
using AutoMapper;

namespace Agendai.Application.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _servicoRepository;
        private readonly IMapper _mapper;

        public ServicoService(IServicoRepository servicoRepository, IMapper mapper)
        {
            _servicoRepository = servicoRepository;
            _mapper = mapper;
        }

        public async Task<ServicoResponse> GetByIdAsync(Guid servicoId)
        {
            var servico = await _servicoRepository.GetByIdAsync(servicoId);
            if (servico == null)
                throw new Exception("Serviço não encontrado.");

            return _mapper.Map<ServicoResponse>(servico);
        }

        public async Task<ServicoResponse> GetByNameAsync(string servicoNome)
        {
            var servico = await _servicoRepository.GetByNameAsync(servicoNome);
            if (servico == null)
                throw new Exception("Serviço não encontrado.");

            return _mapper.Map<ServicoResponse>(servico);
        }

        public async Task<IEnumerable<ServicoResponse>> GetAllAsync()
        {
            var servicos = await _servicoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ServicoResponse>>(servicos);
        }

        public async Task AddAsync(ServicoRequest servicoRequest)
        {
            var servico = _mapper.Map<Servico>(servicoRequest);
            await _servicoRepository.AddAsync(servico);
        }

        public async Task UpdateAsync(Guid id, ServicoRequest servicoRequest)
        {
            var servico = await _servicoRepository.GetByIdAsync(id);
            if (servico == null)
                throw new Exception("Serviço não encontrado.");

            _mapper.Map(servicoRequest, servico);

            await _servicoRepository.UpdateAsync(servico);
        }

        public async Task DeleteAsync(Guid servicoId)
        {
            var servico = await _servicoRepository.GetByIdAsync(servicoId);
            if (servico == null)
                throw new Exception("Serviço não encontrado.");

            await _servicoRepository.DeleteAsync(servicoId);
        }
    }
}
