namespace Agendai.Domain.Entities
{
    public class Servico
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public TimeSpan Duracao { get; set; }
        public Guid EstabelecimentoId { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
    }
}
