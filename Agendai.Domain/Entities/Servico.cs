namespace Agendai.Domain.Entities
{
    public class Servico : Shared.Entities.BaseEntity
    {
        public Guid ServicoId { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public TimeSpan Duracao { get; private set; }
        public Guid EstabelecimentoId { get; private set; }
        public Estabelecimento Estabelecimento { get; private set; }
        protected Servico() : base(Guid.NewGuid()) { }

        protected Servico(string nome, decimal preco, TimeSpan duracao) : base(Guid.NewGuid())
        {
            ServicoId = Guid.NewGuid();

            AlterarNome(nome);
            AlterarPreco(preco);
            AtualizarDuracao(duracao);
        }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome inválido");

            Nome = nome.Trim();
        }

        public void AlterarPreco(decimal preco)
        {
            if (preco > 0)
                throw new Exception("Preço inválido");

            Preco = preco;
        }

        public void AtualizarDuracao(TimeSpan duracao)
        {
            if (duracao > TimeSpan.MinValue)
                throw new Exception("Duração inválida");

            Duracao = duracao;
        }
    }
}
