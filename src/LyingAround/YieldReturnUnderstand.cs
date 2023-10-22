using System;
using System.Collections.Generic;

namespace Lemure.LyingAround;

public class YieldReturnUnderstand
{
	public static void Run()
	{
		Console.WriteLine("Antes de chamar 'Foo'...");
		var foo = Foo();
		Console.WriteLine("Depois de chamar 'Foo'...");

		foreach (var item in foo)
		{
			Console.WriteLine($"Antes de imprimir 'item' {item}");
			Console.WriteLine(item);
			Console.WriteLine($"Depois de imprimir 'item' {item}");
		}
	}

	public static IEnumerable<int> Foo()
	{
		Console.WriteLine("Antes de iniciar o 'loop for'...");

		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine($"Antes do 'yield return {i}'...");
			yield return i;
			Console.WriteLine($"Depois do 'yield return {i}'...");
		}

		Console.WriteLine($"Depois de encerrar o 'loop for'...");
	}
}
