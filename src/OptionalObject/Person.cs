namespace lemure.OptionalObject;

public class Person
{
    public string FirstName { get; }
    public Option<string> LastName { get; }

    private Person(string firstName, Option<string> lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Factories
    public static Person Create(string firstName, string lastName) => new(firstName, Option<string>.Some(lastName));
    public static Person Create(string firstName) => new(firstName, Option<string>.None());
}
