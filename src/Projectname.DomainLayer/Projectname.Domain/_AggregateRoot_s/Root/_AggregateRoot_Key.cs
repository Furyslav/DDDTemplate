using System;
using Projectname.Domain.SeedWork;

namespace Projectname.Domain._AggregateRoot_s.Root
{
    public sealed class _AggregateRoot_Key : KeyValue<Guid>
    {
        public _AggregateRoot_Key(Guid id) : base(id)
        {
        }
    }
}