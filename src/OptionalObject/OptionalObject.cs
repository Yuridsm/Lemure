using System;

namespace lemure.OptionalObject;

public class OptionalObject
{
    public void Run()
    {
        Person? mann = Person.Create("Thomas", "Dann");
        Person? aristotle = Person.Create("Aristotle");
        Person? yuri = Person.Create("Yuri", "Melo");

        Book fautus = Book.Create("Doctor Faustus", mann);
        Book rhetoric = Book.Create("Rhetoric", aristotle);
        Book nights = Book.Create("One Thousand and One Nights");
        Book foo = Book.Create("The most book", yuri, "Description");

        Console.WriteLine(GetBookTitle(fautus));
        Console.WriteLine(GetBookTitle(rhetoric));
        Console.WriteLine(GetBookTitle(nights));
        Console.WriteLine(GetBookTitle(foo));
    }

    // public string GetBookDescription(Book book) =>
    //     book.Author
    //     .Map(GetLabel)
    //     .Reduce("");

    //     // book.Description
    //     // .Map(o => $"Description: {o}")
    //     // .Reduce("No Description");

    public string GetBookTitle(Book book) =>
        book.Author
        .Map(GetLabel)
        .Map(author => $"{book.Title} by {author}")
        .Reduce(book.Title);

    public string GetLabel(Person person) =>
        person.LastName
        .Map(lastName => $"{person.FirstName} {lastName}")
        .Reduce(person.FirstName);
}