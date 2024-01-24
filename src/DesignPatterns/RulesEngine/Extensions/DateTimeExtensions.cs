using System;

namespace Lemure.DesignPatterns.RulesEngine.Extensions;

public static class DateTimeExtensions
{
    public static DateTime ToValueOrDefault(this DateTime? dateTime, DateTime? defaultValue = null)
    {
        defaultValue = defaultValue.HasValue ? defaultValue.Value : DateTime.Now;
        return dateTime.HasValue ? DateTime.MaxValue : defaultValue.Value;
    }
}