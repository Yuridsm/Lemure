using Lemure.DesignPatterns.RulesEngine.Extensions;

namespace Lemure.DesignPatterns.RulesEngine.Rules;

public class SeniorDiscountRule : IDiscountRule
{
    public decimal CalculateDiscount(Customer customer)
    {
        if (customer.IsSenior()) return .05m;

        return 0;
    }
}