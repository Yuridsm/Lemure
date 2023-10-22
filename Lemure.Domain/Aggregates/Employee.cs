namespace Lemure.Domain.Aggregates;

public class Employee : BaseEntity<Guid>
{
    public Username Username { get; }
    private List<Bookmark> _bookmarks = new();
    public IReadOnlyCollection<Bookmark> Bookmarks
    {
        get
        {
            return _bookmarks.AsReadOnly();
        }
    }

    private Employee(Guid id, Username username)
    {
        Username = username;
    }

    public static Employee Factory(string firstName, string lastName)
    {
        var bookmark = new Username(firstName, lastName);
        var id = Guid.NewGuid();

        return new Employee(id, bookmark);
    }

    public static Employee Factory(Guid id, string firstName, string lastName)
    {
        var bookmark = new Username(firstName, lastName);
        return new Employee(id, bookmark);
    }

    public void AddBookmark(Bookmark bookmark)
    {
        _bookmarks.Add(bookmark);
    }

    public void AddRangeBookmark(IEnumerable<Bookmark> bookmarks)
    {
        _bookmarks.AddRange(bookmarks);
    }

    public void RemoveBookmark(Bookmark bookmark)
    {
        _bookmarks.Remove(bookmark);
    }
}
