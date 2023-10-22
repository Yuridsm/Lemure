using Lemure.Domain.Aggregates;

namespace Lemure.Infrastructure;

public interface IReadOnlyRepository<T> where T : BaseEntity<Guid>
{
    T? GetById(Guid id);
    List<T>? List();
}
