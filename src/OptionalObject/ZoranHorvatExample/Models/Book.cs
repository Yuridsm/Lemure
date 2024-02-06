namespace Lemure.OptionalObject.ZoranHorvatExample.Models;

public class Book
{
    public string Title { get; }
    public OptionZoranHorvat<Person> Author { get; }
    public OptionZoranHorvat<string> Description { get; }

    private Book(string title, OptionZoranHorvat<Person> author, OptionZoranHorvat<string> description) =>
        (Title, Author, Description) = (title, author, description);

    // Factories
    public static Book Create(string title) =>
        new(title, OptionZoranHorvat<Person>.None(), OptionZoranHorvat<string>.None());
        
    public static Book Create(string title, Person author) =>
        new(title, OptionZoranHorvat<Person>.Some(author), OptionZoranHorvat<string>.None());

    public static Book Create(string title, Person author, string description) =>
        new(title, OptionZoranHorvat<Person>.Some(author), OptionZoranHorvat<string>.Some(description));

    public override string ToString() =>
        $"Title: {Title} " +
        $"Author: {Author
            .Map(person => person.FirstName)
            .Reduce("[No author]")}" +
        $"Description: {Description
            .Map(_ => _)
            .Reduce("[No Description]")}";
}
