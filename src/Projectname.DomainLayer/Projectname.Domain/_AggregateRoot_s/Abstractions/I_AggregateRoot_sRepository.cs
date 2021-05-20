using System.Threading;
using System.Threading.Tasks;
using Projectname.Domain._AggregateRoot_s.Root;

namespace Projectname.Domain._AggregateRoot_s.Abstractions
{
    public interface I_AggregateRoot_sRepository
    {
        Task AddAsync(_AggregateRoot_ _aggregateRoot_, CancellationToken cancellationToken);
        Task<_AggregateRoot_> GetAsync(_AggregateRoot_Key _aggregateRoot_Key, CancellationToken cancellationToken);
        void Update(_AggregateRoot_ _aggregateRoot_);
        void Remove(_AggregateRoot_ _aggregateRoot_);
    }
}