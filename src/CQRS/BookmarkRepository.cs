using System;
using System.Collections.Generic;
using Lemure.Domain.Aggregates;

namespace Lemure.CQRS;

internal interface IBookmarkRepository
{
	void Create(Bookmark bookmark);
	Bookmark? GetBookmark(Guid id);
	Bookmark Filter(Predicate<Bookmark> predicate);
	IEnumerable<Bookmark> GetBookmarks();
}

internal class BookmarkRepository : IBookmarkRepository
{
	private readonly List<Bookmark> _bookmarks = new();

	public Bookmark? GetBookmark(Guid id)
	{
		return _bookmarks.Find(x => x.Id == id);
	}

	public Bookmark Filter(Predicate<Bookmark> predicate)
	{
		return _bookmarks.Find(predicate);
	}

	public IEnumerable<Bookmark> GetBookmarks()
	{
		return _bookmarks;
	}

	public void Create(Bookmark bookmark)
	{
		_bookmarks.Add(bookmark);
	}
}
