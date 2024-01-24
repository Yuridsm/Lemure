using System;
using Lemure.DesignPatterns.RulesEngine.Extensions;
using Lemure.DesignPatterns.RulesEngine.Rules;

namespace Lemure.DesignPatterns.RulesEngine.Refactor;

public class DiscountCalculatorRefactor : IDiscountRule
{
    public decimal CalculateDiscount(Customer customer)
    {
        decimal discount = 0m;

        if (customer.IsSenior())
        {
            // Senior Discount
            discount = .05m;
        }

        if (customer.IsBirthday())
        {
            discount = Math.Max(discount, 0.1m);
        }

        if (customer.IsExisting())
        {
            if (customer.HasBeenLoyalForYears(1))
            {
                // After 1 year, loyal customers get 10%
                discount = Math.Max(discount, .10m);

                if (customer.HasBeenLoyalForYears(5))
                {
                    // After 5 years, 12%
                    discount = Math.Max(discount, .12m);

                    if (customer.HasBeenLoyalForYears(10))
                    {
                        // After 10 years, 20%
                        discount = Math.Max(discount, .2m);
                    }
                }

                if (customer.IsBirthday())
                {
                    discount += 0.1m;
                }
            }
        }
        else
        {
            // First time purchase discount of 15%
            discount = Math.Max(discount, .15m);
        }

        if (customer.IsVeteran)
        {
            // Veterans get 10%
            discount = Math.Max(discount, .10m);
        }

        return discount;
    }
}