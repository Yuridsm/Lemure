using System;
using Lemure.DesignPatterns.RulesEngine;
using Lemure.DesignPatterns.RulesEngine.NoRefactor;
using Lemure.DesignPatterns.RulesEngine.Rules;

namespace Lemure;

public static class Program
{
    public static void Main(string[] args)
    {
        var customer = new Customer
        {
            DateOfBirth = new DateTime(1998, 1, 12),
            IsVeteran = false,
            DateOfFirstPurchase = new DateTime(2013, 1, 24)
        };

        var result1 = DiscountCalculatorNoRefactor.CalculateDiscountPercentageWithoutPredicates(customer);
        var result2 = DiscountCalculatorNoRefactor.CalculateDiscountPercentageWithPredicates(customer);
        var result3 = DiscountCalculatorNoRefactor.CalculateDiscountPercentageWithExtensionsMethod(customer);

        Console.WriteLine($"O desconto aplicado ao Yuri é: {result1}");
        Console.WriteLine($"O desconto aplicado ao Yuri é: {result2}");
        Console.WriteLine($"O desconto aplicado ao Yuri é: {result3}");

        #region Rules Engine
        DiscountRuleEvaluator evaluator = new DiscountRuleEvaluator();

        var rulesEngineResult = evaluator.CalculateDiscountPercentage(customer);
        Console.WriteLine($"O desconto aplicado ao Yuri é: {rulesEngineResult}");

        #endregion
    }
}
