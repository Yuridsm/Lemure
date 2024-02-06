namespace Lemure.OptionalObject.ZoranHorvatExample.Models;

public class Person
{
    public string FirstName { get; }
    public OptionZoranHorvat<string> LastName { get; }
    public OptionZoranHorvat<Address> Address { get; }

    private Person(string firstName, OptionZoranHorvat<string> lastName, OptionZoranHorvat<Address> address) =>
        (FirstName, LastName, Address) = (firstName, lastName, address);

    public static Person Create(string firstName) =>
        new(firstName, OptionZoranHorvat<string>.None(), OptionZoranHorvat<Address>.None());

    public static Person Create(string firstName, Address address) =>
        new Person(firstName, OptionZoranHorvat<string>.None(), OptionZoranHorvat<Address>.Some(address));

    public static Person Create(string firstName, string lastName) =>
        new(firstName, OptionZoranHorvat<string>.Some(lastName), OptionZoranHorvat<Address>.None());

    public override string ToString() =>
        LastName
        .Map(lastName => $"{FirstName} {LastName}")
        .Reduce(FirstName);
}

public record Address(string Street, string City, string State, string Country);