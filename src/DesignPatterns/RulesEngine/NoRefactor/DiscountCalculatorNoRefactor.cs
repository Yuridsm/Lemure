using System;
using Lemure.DesignPatterns.RulesEngine.Extensions;

namespace Lemure.DesignPatterns.RulesEngine.NoRefactor;

public static class DiscountCalculatorNoRefactor
{
    private const int VETERAN_YEARS_FROM_PAST = -65;

    public static decimal CalculateDiscountPercentageWithoutPredicates(Customer customer)
    {
        decimal discount = 0;

        if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
        {
            // senior discount 5%
            discount = .05m;
        }

        if (customer.DateOfBirth?.Day == DateTime.Today.Day &&
            customer.DateOfBirth?.Month == DateTime.Today.Month)
        {
            // birthday 10%
            discount = Math.Max(discount, .10m);
        }

        if (customer.DateOfFirstPurchase.HasValue)
        {
            if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-1))
            {
                // after 1 year, loyal customers get 10%
                discount = Math.Max(discount, .10m);
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-5))
                {
                    // after 5 years, 12%
                    discount = Math.Max(discount, .12m);
                    if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-10))
                    {
                        // after 10 years, 20%
                        discount = Math.Max(discount, .2m);
                    }
                }

                if (customer.DateOfBirth?.Day == DateTime.Today.Day &&
                    customer.DateOfBirth?.Month == DateTime.Today.Month)
                {
                    // birthday additional 10%
                    discount += .10m;
                }
            }
        }
        else
        {
            // first time purchase discount of 15%
            discount = Math.Max(discount, .15m);
        }
        if (customer.IsVeteran)
        {
            // veterans get 10%
            discount = Math.Max(discount, .10m);
        }

        return discount;
    }

    public static decimal CalculateDiscountPercentageWithPredicates(Customer customer)
    {
        decimal discount = 0;

        if (IsSenior(customer))
        {
            // senior discount 5%
            discount = .05m;
        }

        if (IsBirthday(customer))
        {
            // birthday 10%
            discount = Math.Max(discount, .10m);
        }

        if (IsExisting(customer))
        {
            if (HasBeenLoyalForYears(customer, 1))
            {
                // after 1 year, loyal customers get 10%
                discount = Math.Max(discount, .10m);

                if (HasBeenLoyalForYears(customer, 5))
                {
                    // after 5 years, 12%
                    discount = Math.Max(discount, .12m);

                    if (HasBeenLoyalForYears(customer, 10))
                    {
                        // after 10 years, 20%
                        discount = Math.Max(discount, .2m);
                    }
                }

                if (IsBirthday(customer))
                {
                    // birthday additional 10%
                    discount += .10m;
                }
            }
        }
        else
        {
            // first time purchase discount of 15%
            discount = Math.Max(discount, .15m);
        }
        if (customer.IsVeteran)
        {
            // veterans get 10%
            discount = Math.Max(discount, .10m);
        }

        return discount;
    }

    public static decimal CalculateDiscountPercentageWithExtensionsMethod(Customer customer)
    {
        decimal discount = 0;

        if (customer.IsSenior())
        {
            discount = .05m;
        }

        if (customer.IsBirthday())
        {
            discount = Math.Max(discount, .10m);
        }

        if (customer.IsExisting())
        {
            if (customer.HasBeenLoyalForYears(1))
            {
                discount = Math.Max(discount, .10m);
                if (customer.HasBeenLoyalForYears(5))
                {
                    discount = Math.Max(discount, .12m);
                    if (customer.HasBeenLoyalForYears(10))
                    {
                        discount = Math.Max(discount, .2m);
                    }
                }

                if (customer.IsBirthday())
                {
                    discount += .10m;
                }
            }
        }
        else
        {
            // first time purchase discount of 15%
            discount = Math.Max(discount, .15m);
        }
        if (customer.IsVeteran)
        {
            discount = Math.Max(discount, .10m);
        }

        return discount;
    }
    
    #region Meaningful Predicates
    private static bool HasBeenLoyalForYears(Customer customer, int numberOfYears)
    {
        numberOfYears *= -1;
        return customer.DateOfFirstPurchase < DateTime.Now.AddYears(numberOfYears);
    }

    private static bool IsExisting(Customer customer)
    {
        return customer.DateOfFirstPurchase.HasValue;
    }

    private static bool IsBirthday(Customer customer, DateTime? date = null)
    {
        date = date.ToValueOrDefault();

        return customer.DateOfBirth?.Day   == date.Value.Day &&
               customer.DateOfBirth?.Month == date.Value.Month;
    }

    private static bool IsSenior(Customer customer)
    {
        return customer.DateOfBirth < DateTime.Now.AddYears(VETERAN_YEARS_FROM_PAST);
    }
    #endregion
}