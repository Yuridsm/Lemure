using System;

namespace Lemure.DesignPatterns.Iterator.Entity;

internal class NullObjectProfile : Profile
{
    public NullObjectProfile() : base(Guid.Empty, string.Empty)
    {
    }
}
