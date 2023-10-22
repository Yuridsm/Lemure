using System;
using System.Linq.Expressions;

namespace Lemure.DesignPatterns.Specification.Specs;

public class YearCarSpec : Spec<Car>
{
	public override Expression<Func<Car, bool>> ToExpression()
	{
		return car => car.ModelYear >= DateTime.Now.Year;
	}
}
