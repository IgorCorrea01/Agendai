namespace Agendai.Domain.Entities
{
    public class Estabelecimento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public Guid ProprietarioId { get; set; }
        public Usuario Proprietario { get; set; }
        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();
    }
}
