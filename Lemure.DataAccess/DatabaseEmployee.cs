using Lemure.Infrastructure.DataModel;
using Microsoft.Extensions.Caching.Memory;

namespace Lemure.Infrastructure;

public class DatabaseEmployee
{
    private readonly IMemoryCache _memoryCache;

    public DatabaseEmployee(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public List<EmployeeDataModel> GetEmployees()
    {
        List<EmployeeDataModel> output = new()
        {
            new EmployeeDataModel("Clarisse", "Fonseca"),
            new EmployeeDataModel("Sarah", "Santos"),
            new EmployeeDataModel("Thamirys", "Melo"),
            new EmployeeDataModel("Tânia", "Melo dos Santos")
        };

        Thread.Sleep(3000);

        return output;
    }

    public async Task<List<EmployeeDataModel>> GetEmployeesAsync()
    {
        List<EmployeeDataModel>? output;

        output = _memoryCache.Get<List<EmployeeDataModel>>("employees");

        if (output == null)
        {
            output = new List<EmployeeDataModel>()
            {
                new EmployeeDataModel("Clarisse", "Fonseca"),
                new EmployeeDataModel("Sarah", "Santos"),
                new EmployeeDataModel("Thamirys", "Melo"),
                new EmployeeDataModel("Tânia", "Melo dos Santos")
            };

            await Task.Delay(3000);

            _memoryCache.Set("employees", output, TimeSpan.FromMinutes(1));
        }

        return output;
    }
}
