using System;

namespace Lemure.OptionalObject.ZoranHorvatExample;

/// <summary>
/// Option Pattern implemented by Zoran Horvat
/// </summary>
/// <typeparam name="T"></typeparam>
public class OptionZoranHorvat<T> where T : class
{
    private T? _content = null;

    private OptionZoranHorvat() { }

    public static OptionZoranHorvat<T> Some(T obj) => new() { _content = obj };
    public static OptionZoranHorvat<T> None() => new();

    public OptionZoranHorvat<TResult> Map<TResult>(Func<T, TResult> map)
        where TResult : class =>
            new OptionZoranHorvat<TResult>()
            {
                _content = _content is not null ? map(_content) : null
            };
    
    public T Reduce(T orElse) => _content ?? orElse;
}
