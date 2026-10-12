using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class GreaterThanTotal
    : OneOfBase<
        GreaterThanDecimalTotal,
        GreaterThanStringTotal,
        GreaterThanBooleanTotal,
        GreaterThanDateTotal,
        GreaterThanTimeTotal,
        GreaterThanDatetimeTotal,
        GreaterThanUuidTotal
    >
{
    public GreaterThanTotal(GreaterThanDecimalTotal value)
        : this(
            (OneOf<
                GreaterThanDecimalTotal,
                GreaterThanStringTotal,
                GreaterThanBooleanTotal,
                GreaterThanDateTotal,
                GreaterThanTimeTotal,
                GreaterThanDatetimeTotal,
                GreaterThanUuidTotal
            >)
                value
        )
    { }

    public GreaterThanTotal(GreaterThanStringTotal value)
        : this(
            (OneOf<
                GreaterThanDecimalTotal,
                GreaterThanStringTotal,
                GreaterThanBooleanTotal,
                GreaterThanDateTotal,
                GreaterThanTimeTotal,
                GreaterThanDatetimeTotal,
                GreaterThanUuidTotal
            >)
                value
        )
    { }

    public GreaterThanTotal(GreaterThanBooleanTotal value)
        : this(
            (OneOf<
                GreaterThanDecimalTotal,
                GreaterThanStringTotal,
                GreaterThanBooleanTotal,
                GreaterThanDateTotal,
                GreaterThanTimeTotal,
                GreaterThanDatetimeTotal,
                GreaterThanUuidTotal
            >)
                value
        )
    { }

    public GreaterThanTotal(GreaterThanDateTotal value)
        : this(
            (OneOf<
                GreaterThanDecimalTotal,
                GreaterThanStringTotal,
                GreaterThanBooleanTotal,
                GreaterThanDateTotal,
                GreaterThanTimeTotal,
                GreaterThanDatetimeTotal,
                GreaterThanUuidTotal
            >)
                value
        )
    { }

    public GreaterThanTotal(GreaterThanTimeTotal value)
        : this(
            (OneOf<
                GreaterThanDecimalTotal,
                GreaterThanStringTotal,
                GreaterThanBooleanTotal,
                GreaterThanDateTotal,
                GreaterThanTimeTotal,
                GreaterThanDatetimeTotal,
                GreaterThanUuidTotal
            >)
                value
        )
    { }

    public GreaterThanTotal(GreaterThanDatetimeTotal value)
        : this(
            (OneOf<
                GreaterThanDecimalTotal,
                GreaterThanStringTotal,
                GreaterThanBooleanTotal,
                GreaterThanDateTotal,
                GreaterThanTimeTotal,
                GreaterThanDatetimeTotal,
                GreaterThanUuidTotal
            >)
                value
        )
    { }

    public GreaterThanTotal(GreaterThanUuidTotal value)
        : this(
            (OneOf<
                GreaterThanDecimalTotal,
                GreaterThanStringTotal,
                GreaterThanBooleanTotal,
                GreaterThanDateTotal,
                GreaterThanTimeTotal,
                GreaterThanDatetimeTotal,
                GreaterThanUuidTotal
            >)
                value
        )
    { }

    private GreaterThanTotal(
        OneOf<
            GreaterThanDecimalTotal,
            GreaterThanStringTotal,
            GreaterThanBooleanTotal,
            GreaterThanDateTotal,
            GreaterThanTimeTotal,
            GreaterThanDatetimeTotal,
            GreaterThanUuidTotal
        > input
    )
        : base(input) { }
}
