namespace Lemure.Domain.Aggregates;

public abstract class BaseEntity<TId>
{
    public TId Id { get; protected set; }
}
