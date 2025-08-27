namespace Agendai.Domain.Entities
{
    public class Usuario : Shared.Entities.BaseEntity
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public Enum.EUsuarioRole Role { get; set; }
        protected Usuario() : base(Guid.NewGuid()) { }
        public Usuario(string nome, string email, string senhaHash) : base(Guid.NewGuid())
        {
            UsuarioId = Guid.NewGuid();

            AlterarNome(nome);
            AlterarEmail(email);
            AtualizarSenha(senhaHash);
        }

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome inválido");

            Nome = nome.Trim();
        }

        public void AlterarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email inválido");

            Email = email.Trim().ToLowerInvariant();
        }

        public void AtualizarSenha(string senhaHash)
        {
            if (string.IsNullOrWhiteSpace(senhaHash))
                throw new Exception("Senha inválida");

            SenhaHash = senhaHash;
        }
    }
}
