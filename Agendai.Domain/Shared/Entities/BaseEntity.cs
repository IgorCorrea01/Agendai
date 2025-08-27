namespace Agendai.Domain.Shared.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
        private readonly List<object> _domainEvents = new();
        public IReadOnlyCollection<object> DomainEvents => _domainEvents;

        protected void AddDomainEvent(object @event) => _domainEvents.Add(@event);
        public void ClearDomainEvents() => _domainEvents.Clear();
        public BaseEntity(Guid id)
        {
            Id = id;
        }
    }
}
