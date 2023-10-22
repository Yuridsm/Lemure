using System;
using System.Threading.Tasks;
using Lemure.Infrastructure;

namespace Lemure.Caching;

internal class PerformanceNoCaching
{
    private readonly DatabaseEmployee _databaseEmployee;

    public PerformanceNoCaching(DatabaseEmployee databaseEmployee)
    {
        _databaseEmployee = databaseEmployee;
    }

    public void TestWithoutCaching()
    {
        var items = _databaseEmployee.GetEmployees();

        foreach (var item in items)
            Console.WriteLine($"First: {item.FirstName} Last: {item.LastName}");
    }

    public async Task TestWithCaching()
    {
        var items = await _databaseEmployee.GetEmployeesAsync();

        foreach (var item in items)
            Console.WriteLine($"First: {item.FirstName} Last: {item.LastName}");
    }
}
