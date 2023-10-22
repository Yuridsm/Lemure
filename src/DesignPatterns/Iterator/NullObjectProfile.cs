using System;

namespace Lemure.DesignPatterns.Iterator;

internal class NullObjectProfile : Profile
{
    public NullObjectProfile() : base(Guid.Empty, string.Empty)
    {
    }
}
