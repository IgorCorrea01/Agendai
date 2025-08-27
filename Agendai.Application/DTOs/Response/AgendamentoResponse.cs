namespace Agendai.Application.DTOs.Response
{
    public sealed record AgendamentoResponse(
        Guid AgendamentoId,
        ServicoResponse Servico,
        UsuarioResponse Cliente,
        DateTime DataHora,
        int Status);
}
