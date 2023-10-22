using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Iterator;

internal class Coworker
{
    public Guid Id { get; }
    public List<Profile> Profiles { get; }
    public string Title { get; }
    public string Company { get; }
    public List<string> Interests { get; }
    public DateTime JoinedDate { get; }

    public Coworker(List<Profile> profiles, string title, string company)
    {
        Id = Guid.NewGuid();
        Profiles = profiles;
        Title = title;
        Company = company;
        JoinedDate = DateTime.Now;
    }

    public Coworker(List<Profile> profiles, string title, string company, List<string> interests)
        : this(profiles, title, company)
    {
        Interests = interests;
    }
}