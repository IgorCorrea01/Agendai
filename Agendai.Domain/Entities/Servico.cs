namespace Agendai.Domain.Entities
{
    public class Servico : Shared.Entities.BaseEntity
    {
        public Guid ServicoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public TimeSpan Duracao { get; set; }
        public Guid EstabelecimentoId { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        protected Servico() : base(Guid.NewGuid()) { }
    }
}
