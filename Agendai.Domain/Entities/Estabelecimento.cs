namespace Agendai.Domain.Entities
{
    public class Estabelecimento : Shared.Entities.BaseEntity
    {
        public Guid EstabelecimentoId { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public Guid ProprietarioId { get; private set; }
        public Usuario Proprietario { get; private set; }
        public ICollection<Servico> Servicos { get; private set; } = new List<Servico>();
        protected Estabelecimento() : base(Guid.NewGuid()) { }

        protected Estabelecimento(string nome, string endereco, Usuario proprietario) : base(Guid.NewGuid()) 
        {

        }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome inválido");

            Nome = nome.Trim();
        }

        public void AlterarEndereco(string endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco))
                throw new Exception("Endereço inválido");

            Endereco = endereco.Trim();
        }

        public void AlterarProprietario(Usuario proprietario)
        {
            if (proprietario == null)
                throw new Exception("Usuário inválido");
        }
    }
}
