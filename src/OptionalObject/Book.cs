namespace lemure.OptionalObject;

public class Book
{
    public string Title { get; }
    public Option<Person> Author { get; }
    public Option<string> Description { get; }

    private Book(string title, Option<Person> author, Option<string> description) =>
        (Title, Author, Description) = (title, author, description);

    // Factories
    public static Book Create(string title) =>
        new(title, Option<Person>.None(), Option<string>.None());
        
    public static Book Create(string title, Person author) =>
        new(title, Option<Person>.Some(author), Option<string>.None());

    public static Book Create(string title, Person author, string description) =>
        new(title, Option<Person>.Some(author), Option<string>.Some(description));
}
