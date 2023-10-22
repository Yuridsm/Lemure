using Lemure.Domain.Aggregates;
using Lemure.Infrastructure;

namespace Lemure.Domain;

public class BookmarkRepository : EntityFrameworkRepository<Bookmark>
{
    public BookmarkRepository(EmployeeContext employeeContext) : base(employeeContext)
    {
    }
}
