using System;

namespace Lemure.DesignPatterns.Iterator.Entity;

internal class Profile
{
    public Guid ProfileId { get; }
    public string Username { get; }

    public Profile(Guid profileId, string username)
    {
        ProfileId = profileId;
        Username = username;
    }
}
