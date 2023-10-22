using System;

namespace lemure.OOP.Delegates;

public class FuncDelegate
{
	public static Func<string, string> selector = (string str) => str.ToLower();
}
