using System.ComponentModel.DataAnnotations;

namespace Agendai.Application.DTOs.Request
{
    public sealed record ServicoRequest(
        [Required(ErrorMessage = "O Id do Serviço é obrigatório")]
        Guid ServicoId,
        [Required(ErrorMessage = "O Nome do Serviço é obrigatório")]
        string Nome,
        [Required(ErrorMessage = "O Preço do Serviço é obrigatório")]
        decimal Preco,
        [Required(ErrorMessage = "A Duração do Serviço é obrigatória")]
        TimeSpan Duracao,
        [Required(ErrorMessage = "O Estabelecimento do Serviço é obrigatório")]
        EstabelecimentoRequest Estabelecimento);    
}
