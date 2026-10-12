using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class InTotal
    : OneOfBase<
        InDecimalTotal,
        InStringTotal,
        InBooleanTotal,
        InDateTotal,
        InTimeTotal,
        InDatetimeTotal,
        InUuidTotal
    >
{
    public InTotal(InDecimalTotal value)
        : this(
            (OneOf<
                InDecimalTotal,
                InStringTotal,
                InBooleanTotal,
                InDateTotal,
                InTimeTotal,
                InDatetimeTotal,
                InUuidTotal
            >)
                value
        )
    { }

    public InTotal(InStringTotal value)
        : this(
            (OneOf<
                InDecimalTotal,
                InStringTotal,
                InBooleanTotal,
                InDateTotal,
                InTimeTotal,
                InDatetimeTotal,
                InUuidTotal
            >)
                value
        )
    { }

    public InTotal(InBooleanTotal value)
        : this(
            (OneOf<
                InDecimalTotal,
                InStringTotal,
                InBooleanTotal,
                InDateTotal,
                InTimeTotal,
                InDatetimeTotal,
                InUuidTotal
            >)
                value
        )
    { }

    public InTotal(InDateTotal value)
        : this(
            (OneOf<
                InDecimalTotal,
                InStringTotal,
                InBooleanTotal,
                InDateTotal,
                InTimeTotal,
                InDatetimeTotal,
                InUuidTotal
            >)
                value
        )
    { }

    public InTotal(InTimeTotal value)
        : this(
            (OneOf<
                InDecimalTotal,
                InStringTotal,
                InBooleanTotal,
                InDateTotal,
                InTimeTotal,
                InDatetimeTotal,
                InUuidTotal
            >)
                value
        )
    { }

    public InTotal(InDatetimeTotal value)
        : this(
            (OneOf<
                InDecimalTotal,
                InStringTotal,
                InBooleanTotal,
                InDateTotal,
                InTimeTotal,
                InDatetimeTotal,
                InUuidTotal
            >)
                value
        )
    { }

    public InTotal(InUuidTotal value)
        : this(
            (OneOf<
                InDecimalTotal,
                InStringTotal,
                InBooleanTotal,
                InDateTotal,
                InTimeTotal,
                InDatetimeTotal,
                InUuidTotal
            >)
                value
        )
    { }

    private InTotal(
        OneOf<
            InDecimalTotal,
            InStringTotal,
            InBooleanTotal,
            InDateTotal,
            InTimeTotal,
            InDatetimeTotal,
            InUuidTotal
        > input
    )
        : base(input) { }
}
