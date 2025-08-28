using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;
using Agendai.Domain.Entities;
using Agendai.Domain.Repositories;
using AutoMapper;

namespace Agendai.Application.Services
{
    public sealed class EstabelecimentoService
    {
        private readonly IEstabelecimentoRepository _estabelecimentoRepository;
        private readonly IMapper _mapper;

        public EstabelecimentoService(IEstabelecimentoRepository estabelecimentoRepository, IMapper mapper)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
            _mapper = mapper;
        }

        public async Task<EstabelecimentoResponse> GetByIdAsync(Guid estabelecimentoId)
        {
            var estabelecimento = await _estabelecimentoRepository.GetByIdAsync(estabelecimentoId);
            if (estabelecimento == null)
                throw new Exception("Estabelecimento não encontrado.");

            return _mapper.Map<EstabelecimentoResponse>(estabelecimento);
        }

        public async Task AddAsync(EstabelecimentoRequest estabelecimentoRequest)
        {
            var estabelecimento = _mapper.Map<Estabelecimento>(estabelecimentoRequest);
            await _estabelecimentoRepository.AddAsync(estabelecimento);
        }

        public async Task UpdateAsync(Guid id, EstabelecimentoRequest estabelecimentoRequest)
        {
            var estabelecimento = await _estabelecimentoRepository.GetByIdAsync(id);
            if (estabelecimento == null)
                throw new Exception("Estabelecimento não encontrado.");

            _mapper.Map(estabelecimentoRequest, estabelecimento);

            await _estabelecimentoRepository.UpdateAsync(estabelecimento);
        }

        public async Task DeleteAsync(Guid estabelecimentoId)
        {
            var estabelecimento = await _estabelecimentoRepository.GetByIdAsync(estabelecimentoId);
            if (estabelecimento == null)
                throw new Exception("Estabelecimento não encontrado.");

            await _estabelecimentoRepository.DeleteAsync(estabelecimentoId);
        }
    }
}
