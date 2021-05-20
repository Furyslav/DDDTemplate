using System;

namespace Projectname.Domain.SeedWork
{
    public interface IDomainKey<TKey>
    {
        TKey Id { get; protected set; }
    }
}