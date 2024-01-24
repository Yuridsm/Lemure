namespace Lemure.DesignPatterns.RulesEngine.Rules;

public class VeteranDiscountRule : IDiscountRule
{
    public decimal CalculateDiscount(Customer customer)
    {
        if (customer.IsVeteran) return .10m;
        
        return 0;
    }
}