using System.Collections.Generic;
using Projectname.Domain.SeedWork;

namespace Projectname.Domain._AggregateRoot_s.Root
{
    public sealed class _AggregateRoot_ : IAggregateRoot<_AggregateRoot_Key>
    {
        public IDomainKey<_AggregateRoot_Key> Id { get; set; }

        ICollection<IDomainEvent> IAggregateRoot<_AggregateRoot_Key>.Events { get; set; }
    }
}