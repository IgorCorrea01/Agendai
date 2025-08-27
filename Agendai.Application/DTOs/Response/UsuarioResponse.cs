namespace Agendai.Application.DTOs.Response
{
    public sealed record UsuarioResponse(
        Guid UsuarioId,
        string Nome,
        string Email,
        int Role);
}
