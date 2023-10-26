using System;
using System.Collections.Generic;
using Lemure.DesignPatterns.Iterator.Entity;

namespace Lemure.DesignPatterns.Iterator.Factory;

internal interface FacebookRequestFactory
{
    List<Profile> GetFriendsFromGraphDatabase(Guid profileId);
    List<Coworker> GetCoworkerFromGraphDatabase(Guid profileId, string company);
}
