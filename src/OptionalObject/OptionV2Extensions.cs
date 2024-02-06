using System;
using System.Collections.Generic;

namespace Lemure.OptionalObject;

public static class OptionV2extensions
{
    public static U Match<T, U>(this OptionV2<T> option, Func<T, U> onIsSome, Func<U> onIsNone)
        where T : notnull =>
            option.IsSome(out var value) ? onIsSome(value) : onIsNone();

    public static OptionV2<U> Bind<T, U>(this OptionV2<T> option, Func<T, OptionV2<U>> binder)
        where T : notnull
        where U : notnull =>
            option.Match(binder, () => OptionV2<U>.None);
    
    public static OptionV2<U> Map<T, U>(this OptionV2<T> option, Func<T, U> mapper)
        where T : notnull
        where U : notnull =>
            option.Bind(value => OptionV2<U>.Some(mapper(value)));
    
    public static OptionV2<T> Filter<T>(this OptionV2<T> option, Predicate<T> predicate)
        where T : notnull =>
            option.Bind(value => predicate(value) ? option : OptionV2<T>.None);
    
    public static T DefaultValue<T>(this OptionV2<T> option, T defaultValue)
        where T : notnull =>
            option.Match(value => value, () => defaultValue);
}

public class Student
{
    public Guid Identifier { get; }
    public string FirstName { get; }
    public OptionV2<string> LastName { get; } = OptionV2<string>.None;
    public string Description { get; }
    public OptionV2<DateTime> StartDateTime { get; } = OptionV2<DateTime>.None;
    public List<Guid> Courses { get; } = new();

    public Student(string firstName)
    {
        Identifier = Guid.NewGuid();
        FirstName =  firstName;
        Description = string.Empty;
    }

    public void AddCourses(IEnumerable<Guid> ids) => Courses.AddRange(ids);
    public void AddCourse(Guid id) => Courses.Add(id);
}

public record Course(Guid CourseIdentifier, string Name);

public class Test
{
    public static void Run()
    {
        var student = new Student("Yuri dos Santos Melo");

        var course01 = new Course(Guid.NewGuid(), "Chemical Engineering");
        var course02 = new Course(Guid.NewGuid(), "Mechanical Engineering");
        var course03 = new Course(Guid.NewGuid(), "Environment Engineering");

        student.AddCourse(course01.CourseIdentifier);
        student.AddCourse(course02.CourseIdentifier);
        student.AddCourse(course03.CourseIdentifier);

        
        
        Console.WriteLine(student);
    }
}