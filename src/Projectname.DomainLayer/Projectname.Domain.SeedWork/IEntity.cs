namespace Projectname.Domain.SeedWork
{
    public interface IEntity<TKey>
    {
        IDomainKey<TKey> Id { get; }
    }
}