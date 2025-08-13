namespace Agendai.Domain.Shared.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
        public BaseEntity(Guid id)
        {
            Id = id;
        }
    }
}
