namespace Agendai.Application.DTOs.Response
{
    public sealed record ServicoResponse(
        Guid ServicoId,
        string Nome,
        decimal Preco,
        TimeSpan duracao,
        Guid Estabelecimento
        );
}
