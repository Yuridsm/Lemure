using System;
using System.Linq.Expressions;

namespace Lemure.DesignPatterns.Specification.Specs;

public class LuxuryCarSpecification : Spec<Car>
{
	public override Expression<Func<Car, bool>> ToExpression()
	{
		return car => car.Color == Color.Black
			&& car.ModelYear >= DateTime.Now.Year - 2
			&& car.CarBody == CarBody.Seda;
	}
}
