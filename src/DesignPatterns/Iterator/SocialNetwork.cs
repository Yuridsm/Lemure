using System;

namespace Lemure.DesignPatterns.Iterator;

internal interface SocialNetwork
{
    ProfileIterator CreateFriendsIterator(Guid profileId);
    ProfileIterator CreateCoworkersIterator(Guid profileId);
}
