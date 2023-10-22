namespace Lemure.Domain.Aggregates;

[Flags]
public enum BookmarkFlag
{
    Created,
    Deleted,
    Updated,
    Assembled
}

public class BookmarkChangingHistory
{
    public Bookmark Bookmark { get; private set; }
    public DateTime DateTime { get; private set; }
    public BookmarkFlag Flag { get; private set; }

    public BookmarkChangingHistory(Bookmark bookmark, DateTime dateTime, BookmarkFlag flag)
    {
        Bookmark = bookmark;
        DateTime = dateTime;
        Flag = flag;
    }
}

public class Bookmark : BaseEntity<Guid>
{
    private List<string> _links { get; set; } = new();
    private List<BookmarkChangingHistory> _changingHistory { get; set; } = new();


    public string Title { get; private set; }
    public string Description { get; private set; }
    public IReadOnlyCollection<string> Links => _links.AsReadOnly<string>();
    public IReadOnlyCollection<BookmarkChangingHistory> ChangingHistory => _changingHistory.AsReadOnly<BookmarkChangingHistory>();

    public Bookmark(string title, string description)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        _changingHistory.Add(new BookmarkChangingHistory(this, DateTime.Now, BookmarkFlag.Created));
    }

    public Bookmark(Guid id, string title, string description) : this(title, description)
    {
        Id = id;
        _changingHistory.Add(new BookmarkChangingHistory(this, DateTime.Now, BookmarkFlag.Assembled));
    }

    public void UpdateTitle(string title)
    {
        Title = title;
        _changingHistory.Add(new BookmarkChangingHistory(this, DateTime.Now, BookmarkFlag.Updated));
    }

    public void UpdateDescription(string description)
    {
        Description = description;
        _changingHistory.Add(new BookmarkChangingHistory(this, DateTime.Now, BookmarkFlag.Updated));
    }
}
