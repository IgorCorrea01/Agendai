using Agendai.Application.DTOs.Request;
using Agendai.Application.DTOs.Response;
using Agendai.Domain.Entities;
using Agendai.Domain.Entities.Enum;
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
            CreateMap<RegistroRequest, Usuario>().ForMember(dest => dest.Role, opt => opt.MapFrom(src => Enum.Parse<EUsuarioRole>(src.Role, true)));
            CreateMap<Usuario, UsuarioResponse>().ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()));
        }
    }
}
