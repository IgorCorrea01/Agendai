using System.ComponentModel.DataAnnotations;

namespace Agendai.Application.DTOs.Request
{
    public sealed record AgendamentoRequest(
        [Required(ErrorMessage = "O Serviço do Agendamento é obrigatório")]
        ServicoRequest Servico,
        [Required(ErrorMessage = "O Usuário do Agendamento é obrigatório")]
        Guid UsuarioId,
        [Required(ErrorMessage = "A Data do Agendamento é obrigatório")]
        DateTime DataHora,
        [Required(ErrorMessage = "O Status do Agendamento é obrigatório")]
        int Status);
}
