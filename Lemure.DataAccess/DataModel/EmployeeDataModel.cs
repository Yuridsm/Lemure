namespace Lemure.Infrastructure.DataModel;

public class EmployeeDataModel
{
    public string FirstName { get; }
    public string LastName { get; }

    public EmployeeDataModel(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
