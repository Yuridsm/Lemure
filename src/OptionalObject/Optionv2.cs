using System;
using System.Diagnostics.CodeAnalysis;
using Google.Protobuf.WellKnownTypes;

namespace Lemure.OptionalObject;

public class OptionV2<T> where T : notnull
{
    public static OptionV2<T> None => default;
    public static OptionV2<T> Some(T value) => new OptionV2<T>(value);

    readonly bool isSome;
    readonly T Value;

    OptionV2(T value)
    {
        Value = value;
        isSome = this.Value is {};
    }

    public bool IsSome([MaybeNullWhen(false)]out T value)
    {
        value = this.Value;
        return isSome;
    }
}