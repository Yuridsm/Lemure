using System;
using Lemure.DesignPatterns.RulesEngine.Extensions;
using Lemure.DesignPatterns.RulesEngine.Rules;

namespace Lemure.DesignPatterns.RulesEngine;

public class LoyalCustomerRule : IDiscountRule
{
    private readonly int _yearsAsCustomer;
    private readonly decimal _discount;
    private readonly DateTime _date;

    public LoyalCustomerRule(int yearsAsCustomer, decimal discount, DateTime? date = null)
    {
        _yearsAsCustomer = yearsAsCustomer;
        _discount = discount;
        _date = date.ToValueOrDefault();
    }

    public decimal CalculateDiscount(Customer customer)
    {
        if (customer.HasBeenLoyalForYears(_yearsAsCustomer, _date))
        {
            var birthdayRule = new BirthdayDiscountRule();

            return _discount + birthdayRule.CalculateDiscount(customer);
        }
        
        return 0;
    }
}