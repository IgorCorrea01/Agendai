namespace Agendai.Application.DTOs.Response
{
    public sealed record EstabelecimentoResponse(
        Guid EstabelecimentoId,
        string Nome,
        string Endereco,
        UsuarioResponse Proprietario,
        List<ServicoResponse> Servicos);
}
