using System;

namespace Lemure.Delegates;

public class Student
{
    public Guid Identifier { get; }
    public string FullName { get; } = string.Empty;

    public Student(string fullname)
    {
        Identifier = Guid.NewGuid();
        FullName  = fullname;
    }

    public override string ToString() => $"Id: {Identifier} Full Name: {FullName}";
}

public class FuncStudy
{
    delegate void CreateStudentDelegate(string fullname);
    delegate Student GetStudentByIdDelegate(Guid identifier);

    public static void Execute()
    {
        // Delegates
        CreateStudentDelegate createStudent = CreateStudent;
        GetStudentByIdDelegate getStudent = GetStudentById;

        createStudent("Yuri Melo");
        var student01 = getStudent(Guid.NewGuid());
        Console.WriteLine(student01);

        // Action
        Action<string> createStudentWithAction = CreateStudent;

        createStudentWithAction("Igor Melo");

        // Func
        Func<Guid, Student> getStudentByIdWithFunc = GetStudentById;

        var student02 = getStudentByIdWithFunc(Guid.NewGuid());
        Console.WriteLine(student02);
    }

    static void CreateStudent(string fullname) => new Student(fullname);

    static Student GetStudentById(Guid identifier)
    {
        if (identifier == Guid.Empty) throw new Exception("Invalid Identifier");

        // search in data source ...
        return new Student("Canonical Student");
    }
}