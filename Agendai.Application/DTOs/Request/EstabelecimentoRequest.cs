using System.ComponentModel.DataAnnotations;

namespace Agendai.Application.DTOs.Request
{
    public sealed record EstabelecimentoRequest(
        [Required(ErrorMessage = "O Id do Estabelecimento é obrigatório")]
        Guid EstabelecimentoId,
        [Required(ErrorMessage = "O Nome do Estabelecimento é obrigatório")]
        [StringLength(50, ErrorMessage = "O Nome deve ter no máximo 50 caracteres")]
        string Nome,
        [Required(ErrorMessage = "O Endereço do Estabelecimento é obrigatório")]
        [StringLength(255,ErrorMessage = "O Endereço deve ter no máximo 255 caracteres")]
        string Endereco,
        [Required(ErrorMessage = "O Usuário do Estabelecimento é obrigatório")]
        Guid UsuarioId,
        List<ServicoRequest> Servicos);
}
