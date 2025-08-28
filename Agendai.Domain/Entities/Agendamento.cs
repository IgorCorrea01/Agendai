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

        public Agendamento(Guid servicoId, Guid clienteId, DateTime dataHora)
            : base(Guid.NewGuid())
        {
            if (servicoId == Guid.Empty)
                throw new Exception("Serviço inválido");

            if (clienteId == Guid.Empty)
                throw new Exception("Cliente inválido");

            if (dataHora < DateTime.UtcNow)
                throw new Exception("Data e hora do agendamento não podem ser no passado");

            AgendamentoId = Guid.NewGuid();
            ServicoId = servicoId;
            ClienteId = clienteId;
            DataHora = dataHora;
            Status = Enum.EAgendamentoStatus.Pendente; // status inicial
        }

        public void AlterarDataHora(DateTime novaDataHora)
        {
            if (novaDataHora < DateTime.UtcNow)
                throw new Exception("Data e hora do agendamento não podem ser no passado");

            DataHora = novaDataHora;
        }

        public void AlterarStatus(Enum.EAgendamentoStatus novoStatus)
        {
            Status = novoStatus;
        }
    }
}
