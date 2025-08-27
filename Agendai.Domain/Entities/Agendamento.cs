namespace Agendai.Domain.Entities
{
    public class Agendamento : Shared.Entities.BaseEntity
    {
        public Guid AgendamentoId { get; private set; }
        public Guid ServicoId { get; private set; }
        public Servico Servico { get; private set; }
        public Guid ClienteId { get; private set; }
        public Usuario Cliente { get; private set; }
        public DateTime DataHora { get; private set; }
        public Enum.EAgendamentoStatus Status { get; private set; }
        protected Agendamento() : base(Guid.NewGuid()) { }

    }
}
