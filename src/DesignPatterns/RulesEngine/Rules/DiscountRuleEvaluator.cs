using System;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.RulesEngine.Rules;

public class DiscountRuleEvaluator
{
    List<IDiscountRule> _rules = new List<IDiscountRule>();

    public DiscountRuleEvaluator()
    {
        _rules.Add(new BirthdayDiscountRule());
        _rules.Add(new SeniorDiscountRule());
        _rules.Add(new VeteranDiscountRule());
        _rules.Add(new NewCustomerDiscountRule());
        _rules.Add(new LoyalCustomerRule(1, 0.10m));
        _rules.Add(new LoyalCustomerRule(5, 0.12m));
        _rules.Add(new LoyalCustomerRule(10, 0.20m));
    }

    public DiscountRuleEvaluator(IEnumerable<IDiscountRule> rules)
    {
        _rules.AddRange(rules);
    }

    public decimal CalculateDiscountPercentage(Customer customer)
    {
        decimal discount = .0m;

        foreach(var rule in _rules)
        {
            discount = Math.Max(discount, rule.CalculateDiscount(customer));
        }

        return discount;
    }
}