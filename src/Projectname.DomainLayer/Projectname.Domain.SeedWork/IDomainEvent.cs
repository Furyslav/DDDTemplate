using System;

namespace Projectname.Domain.SeedWork
{
    public interface IDomainEvent
    {
        Guid Id { get; set; }
        DateTimeOffset Created { get; set; }
    }
}