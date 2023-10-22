using Lemure.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace Lemure.Infrastructure;

public class EmployeeContext : DbContext
{
    public const int MAX_EMPLOYEES = 3;

    public DbSet<Employee> Employee { get; set; }
    public DbSet<Bookmark> Bookmark { get; set; }

    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
    {
    }

    private List<Employee> GetEmployees()
    {
        var list = new List<Employee>
        {
            Domain.Aggregates.Employee.Factory("1. Yuri", "Melo")
        };

        for (int i = 0; i < MAX_EMPLOYEES; i++)
        {
            list.Add(Domain.Aggregates.Employee.Factory($"{i}. Yuri", "Melo"));
        }
        return list;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var employees = GetEmployees();

        employees.First().AddBookmark(new Bookmark("Title 1", "Bookmark description"));

        builder
            .Entity<Employee>()
            .HasData(employees.ToArray());
    }
}
