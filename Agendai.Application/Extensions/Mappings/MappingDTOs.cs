using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;
using Agendai.Domain.Entities;
using AutoMapper;

namespace Agendai.Application.Extensions.Mappings
{
    public class MappingDTOs : Profile
    {
        public MappingDTOs()
        {
            // Agendamento
            CreateMap<AgendamentoRequest, Agendamento>();
            CreateMap<Agendamento, AgendamentoResponse>();

            // Estabelecimento
            CreateMap<EstabelecimentoRequest, Estabelecimento>();
            CreateMap<Estabelecimento, EstabelecimentoResponse>();

            // Serviço
            CreateMap<ServicoRequest, Servico>();
            CreateMap<Servico, ServicoResponse>();

            // Usuário
            CreateMap<RegistroRequest, Usuario>();
            CreateMap<Usuario, UsuarioResponse>();
        }
    }
}
