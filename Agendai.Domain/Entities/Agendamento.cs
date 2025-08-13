namespace Agendai.Domain.Entities
{
    public class Agendamento
    {
        public Guid Id { get; set; }
        public Guid ServicoId { get; set; }
        public Servico Servico { get; set; } = null!;
        public Guid ClienteId { get; set; }
        public Usuario Cliente { get; set; } = null!;
        public DateTime DataHora { get; set; }
        public Enum.EAgendamentoStatus Status { get; set; }
    }
}
