using Lemure.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace Lemure.Infrastructure;

public class EntityFrameworkRepository<T> : IRepository<T> where T : BaseEntity<Guid>
{
    protected readonly EmployeeContext _dbContext;

    public EntityFrameworkRepository(EmployeeContext employeeContext)
    {
        _dbContext = employeeContext;
    }

    public T Add(T entity)
    {
        _dbContext.Set<T>().Add(entity);
        _dbContext.SaveChanges();

        return entity;
    }

    public void Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        _dbContext.SaveChanges();
    }

    public T? GetById(Guid id)
    {
        return _dbContext
            .Set<T>()
            .SingleOrDefault(e => e.Id == id);
    }

    public virtual List<T>? List()
    {
        return _dbContext.Set<T>().ToList();
    }

    public void Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }
}
