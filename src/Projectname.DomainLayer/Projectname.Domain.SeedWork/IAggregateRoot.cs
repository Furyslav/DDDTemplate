using System.Collections.Generic;

namespace Projectname.Domain.SeedWork
{
    public interface IAggregateRoot<TKey> : IEntity<TKey>
    {
        ICollection<IDomainEvent> Events { get; protected set; }
    }
}