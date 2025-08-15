namespace Agendai.Application.DTOs.Response
{
    public sealed record UsuarioResponse(
        Guid Id,
        string Nome,
        string Email,
        int Role
        );
}
