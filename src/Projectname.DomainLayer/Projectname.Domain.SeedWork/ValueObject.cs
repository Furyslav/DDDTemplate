namespace Projectname.Domain.SeedWork
{
    public abstract class KeyValue<TValue>
    {
        public TValue Value { get; protected set; }

        public KeyValue(TValue keyValue) => Value = keyValue;
    }
}