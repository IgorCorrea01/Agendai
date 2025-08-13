namespace Agendai.Domain.Entities
{
    public abstract class Agendamento : Shared.Entities.BaseEntity
    {
        public Guid AgendamentoId { get; set; }
        public Guid ServicoId { get; set; }
        public Servico Servico { get; set; } = null!;
        public Guid ClienteId { get; set; }
        public Usuario Cliente { get; set; } = null!;
        public DateTime DataHora { get; set; }
        public Enum.EAgendamentoStatus Status { get; set; }
        protected Agendamento() : base(Guid.NewGuid()) { }

    }
}
