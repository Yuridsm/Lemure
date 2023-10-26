using System;
using System.Collections.Generic;
using System.Linq;
using Lemure.DesignPatterns.Iterator.Contracts;
using Lemure.DesignPatterns.Iterator.Entity;
using Lemure.DesignPatterns.Iterator.Factory;
using Lemure.DesignPatterns.Iterator.Iterators;

namespace Lemure.DesignPatterns.Iterator.Enumerable;

internal class Facebook : ISocialNetwork, FacebookRequestFactory
{
    private readonly List<Profile> _users = new List<Profile>
    {
        new Profile(new Guid("063d509c-3d9f-44aa-84e5-fd111fa07af6"), "Thamirys"),
        new Profile(new Guid("b2c67609-685c-4240-93ce-4dfd00bc7b40"), "Yuri"),
        new Profile(new Guid("7fa12389-86f9-4f60-8bde-b127c13085d8"), "Pedro"),

        new Profile(new Guid("0a4ba7ee-05ca-4ca0-b8b4-42af8f12a0a4"), "Igor"),
        new Profile(new Guid("fff511d7-847e-45a3-bad5-351ddcb6fb8e"), "Iran"),
        new Profile(new Guid("aeb1382a-4678-4bf0-b78d-2d8e5f86cb23"), "Trump")
    };

    private readonly List<Coworker> _profies = new List<Coworker>();

    public Facebook()
    {
        _profies.Add(new Coworker(_users.Take(3).ToList(), "The Apple Cowork", "Apple"));
        _profies.Add(new Coworker(_users.TakeLast(3).ToList(), "The Microsoft Cowork", "Microsoft"));
    }

    public IProfileIterator CreateCoworkersIterator(Guid profileId)
    {
        return new FacebookIterator(this, profileId);
    }

    public IProfileIterator CreateFriendsIterator(Guid profileId)
    {
        return new FacebookIterator(this, profileId);
    }

    public List<Coworker> GetCoworkerFromGraphDatabase(Guid profileId, string company)
    {
        return _profies.Where(o => o.Id == profileId && o.Company == company).ToList();
    }

    public List<Profile> GetFriendsFromGraphDatabase(Guid profileId)
    {
        var profiles = _users.Take(3).ToList();

        var selectedProfiles = profiles.Select(o => o.ProfileId);

        if (selectedProfiles.Contains(profileId)) return profiles;

        return _users.TakeLast(3).ToList();
    }
}
