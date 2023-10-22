using Lemure.Domain.Aggregates;

namespace Lemure.Infrastructure;

public interface IRepository<T> : IReadOnlyRepository<T> where T : BaseEntity<Guid>
{
    T Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
