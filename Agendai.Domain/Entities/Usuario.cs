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
    }
}
