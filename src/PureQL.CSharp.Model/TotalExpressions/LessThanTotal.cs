using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class LessThanTotal
    : OneOfBase<
        LessThanDecimalTotal,
        LessThanStringTotal,
        LessThanBooleanTotal,
        LessThanDateTotal,
        LessThanTimeTotal,
        LessThanDatetimeTotal,
        LessThanUuidTotal
    >
{
    public LessThanTotal(LessThanDecimalTotal value)
        : this(
            (OneOf<
                LessThanDecimalTotal,
                LessThanStringTotal,
                LessThanBooleanTotal,
                LessThanDateTotal,
                LessThanTimeTotal,
                LessThanDatetimeTotal,
                LessThanUuidTotal
            >)
                value
        )
    { }

    public LessThanTotal(LessThanStringTotal value)
        : this(
            (OneOf<
                LessThanDecimalTotal,
                LessThanStringTotal,
                LessThanBooleanTotal,
                LessThanDateTotal,
                LessThanTimeTotal,
                LessThanDatetimeTotal,
                LessThanUuidTotal
            >)
                value
        )
    { }

    public LessThanTotal(LessThanBooleanTotal value)
        : this(
            (OneOf<
                LessThanDecimalTotal,
                LessThanStringTotal,
                LessThanBooleanTotal,
                LessThanDateTotal,
                LessThanTimeTotal,
                LessThanDatetimeTotal,
                LessThanUuidTotal
            >)
                value
        )
    { }

    public LessThanTotal(LessThanDateTotal value)
        : this(
            (OneOf<
                LessThanDecimalTotal,
                LessThanStringTotal,
                LessThanBooleanTotal,
                LessThanDateTotal,
                LessThanTimeTotal,
                LessThanDatetimeTotal,
                LessThanUuidTotal
            >)
                value
        )
    { }

    public LessThanTotal(LessThanTimeTotal value)
        : this(
            (OneOf<
                LessThanDecimalTotal,
                LessThanStringTotal,
                LessThanBooleanTotal,
                LessThanDateTotal,
                LessThanTimeTotal,
                LessThanDatetimeTotal,
                LessThanUuidTotal
            >)
                value
        )
    { }

    public LessThanTotal(LessThanDatetimeTotal value)
        : this(
            (OneOf<
                LessThanDecimalTotal,
                LessThanStringTotal,
                LessThanBooleanTotal,
                LessThanDateTotal,
                LessThanTimeTotal,
                LessThanDatetimeTotal,
                LessThanUuidTotal
            >)
                value
        )
    { }

    public LessThanTotal(LessThanUuidTotal value)
        : this(
            (OneOf<
                LessThanDecimalTotal,
                LessThanStringTotal,
                LessThanBooleanTotal,
                LessThanDateTotal,
                LessThanTimeTotal,
                LessThanDatetimeTotal,
                LessThanUuidTotal
            >)
                value
        )
    { }

    private LessThanTotal(
        OneOf<
            LessThanDecimalTotal,
            LessThanStringTotal,
            LessThanBooleanTotal,
            LessThanDateTotal,
            LessThanTimeTotal,
            LessThanDatetimeTotal,
            LessThanUuidTotal
        > input
    )
        : base(input) { }
}
