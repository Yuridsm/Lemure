using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Iterator;

internal interface FacebookRequestFactory
{
    List<Profile> GetFriendsFromGraphDatabase(Guid profileId);
    List<Coworker> GetCoworkerFromGraphDatabase(Guid profileId, string company);
}
