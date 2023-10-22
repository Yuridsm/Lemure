using System;
using System.Linq.Expressions;

namespace Lemure.Expression;

public class Student
{
	public Guid Id { get; } = Guid.NewGuid();
	public string Name { get; private set; }
	public int Age { get; private set; }

	public static Student Create(string name, int age)
	{
		Student student = new Student();

		student.Name = name;
		student.Age = age;

		return student;
	}

	private Student() { }

	public override string ToString()
	{
		return $"Id: {Id}. Name {Name} with Age = {Age}";
	}

	public bool CanEntryInParty(Expression<Func<Student, bool>> expression)
	{
		return expression.Compile().Invoke(this);
	}
}

public class ExpressionClient
{
	public static void Run()
	{

		#region Func
		Func<int, int, bool> testForEquality = (int x, int y) => x == y;
		Func<int, int> square = x => x * x;
		#endregion

		#region Action
		Action<string> greet = name =>
		{
			string greeting = $"Hello {name}!";
			Console.WriteLine(greeting);
		};

		Action line = () => Console.WriteLine("Olá...");
		#endregion

		#region Expression
		Expression<Func<Student, bool>> isOlderThanExpression = student => student.Age > 21 && student.Age < 20;
		Expression<Action<Student>> printStudentNameExpression = student => Console.WriteLine(student.Name);

		Func<Student, bool> isOlderThan = isOlderThanExpression.Compile();
		Action<Student> printStudentName = printStudentNameExpression.Compile();

		Student student = Student.Create("Yrlan", 24);

		int ageForEntryInParty = 30;

		Console.WriteLine(isOlderThan(student));
		printStudentName(student);
		#endregion

		Console.WriteLine(student.CanEntryInParty(o => o.Age >= ageForEntryInParty) == true ? "Pode" : "Não Pode");
	}
}
