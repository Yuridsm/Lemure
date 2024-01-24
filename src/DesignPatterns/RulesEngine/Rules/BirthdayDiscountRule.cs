using Lemure.DesignPatterns.RulesEngine.Extensions;

namespace Lemure.DesignPatterns.RulesEngine.Rules;

public class BirthdayDiscountRule : IDiscountRule
{
    public decimal CalculateDiscount(Customer customer)
    {
        return customer.IsBirthday() ? 0.10m : 0;
    }
}