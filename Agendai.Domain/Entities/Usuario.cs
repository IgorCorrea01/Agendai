namespace Agendai.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public Enum.EUsuarioRole Role { get; set; }
    }
}
