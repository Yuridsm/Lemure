namespace Lemure.DesignPatterns.RulesEngine.Rules;

public interface IDiscountRule
{
    decimal CalculateDiscount(Customer customer);
}