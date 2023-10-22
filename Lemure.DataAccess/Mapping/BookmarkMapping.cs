using Lemure.Domain.Aggregates;
using Lemure.Infrastructure.DataModel;

namespace Lemure.Infrastructure.Mapping;

public static class BookmarkMapping
{
    public static BookmarkDataModel MapToDataModel(Bookmark domain)
    {
        return new BookmarkDataModel(domain.Id, domain.Title, domain.Description);
    }

    public static IEnumerable<BookmarkDataModel> MapToDataModel(IEnumerable<Bookmark> domain)
    {
        var bookmarks = new List<BookmarkDataModel>();

        foreach (var item in domain)
            bookmarks.Add(MapToDataModel(item));

        return bookmarks;
    }

    public static Bookmark MapToDomainModel(BookmarkDataModel dataModel)
    {
        return new Bookmark(dataModel.Id, dataModel.Title, dataModel.Description);
    }

    public static IEnumerable<Bookmark> MapToDomainModel(IEnumerable<BookmarkDataModel> dataModel)
    {
        var bookmarks = new List<Bookmark>();

        foreach (var item in dataModel)
            bookmarks.Add(MapToDomainModel(item));

        return bookmarks;
    }
}
