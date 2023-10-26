using System;

namespace Lemure.DesignPatterns.Iterator.Contracts;

internal interface ISocialNetwork
{
    IProfileIterator CreateFriendsIterator(Guid profileId);
    IProfileIterator CreateCoworkersIterator(Guid profileId);
}
