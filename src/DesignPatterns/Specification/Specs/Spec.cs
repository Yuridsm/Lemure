using System;
using System.Linq.Expressions;

namespace Lemure.DesignPatterns.Specification.Specs;

public abstract class Spec<T> where T : class
{
	public abstract Expression<Func<T, bool>> ToExpression();

	public bool IsSatisfiedBy(T car)
	{
		var predicate = ToExpression().Compile();
		return predicate(car);
	}
}
