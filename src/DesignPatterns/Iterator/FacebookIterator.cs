using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Iterator;

internal class FacebookIterator : ProfileIterator
{
    private readonly FacebookRequestFactory _iterable;
    private int _position = 0;
    private List<Profile> _cache = new();
    private Guid _profileId;

    public FacebookIterator(FacebookRequestFactory iterable, Guid profileId)
    {
        _iterable = iterable;
        _profileId = profileId;
    }

    private void LazyInit()
    {
        if (_cache.Count == 0)
            _cache = _iterable.GetFriendsFromGraphDatabase(_profileId);
    }

    public Profile GetNext()
    {
        if (!HasMore()) return new NullObjectProfile(); // Null Object Pattern

        var result = _cache[_position];
        _position++;
        return result;
    }

    public bool HasMore()
    {
        LazyInit();

        return _position < _cache.Count;
    }

    public void Reset() => _position = 0;
}
