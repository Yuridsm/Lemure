namespace Lemure.DesignPatterns.RulesEngine.Rules;

public class NewCustomerDiscountRule : IDiscountRule
{
    public decimal CalculateDiscount(Customer customer)
    {
        if (!customer.DateOfFirstPurchase.HasValue) return .15m;
        
        return 0;
    }
}