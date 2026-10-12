using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class GreaterThanOrEqualTotal
    : OneOfBase<
        GreaterThanOrEqualDecimalTotal,
        GreaterThanOrEqualStringTotal,
        GreaterThanOrEqualBooleanTotal,
        GreaterThanOrEqualDateTotal,
        GreaterThanOrEqualTimeTotal,
        GreaterThanOrEqualDatetimeTotal,
        GreaterThanOrEqualUuidTotal
    >
{
    public GreaterThanOrEqualTotal(GreaterThanOrEqualDecimalTotal value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalTotal,
                GreaterThanOrEqualStringTotal,
                GreaterThanOrEqualBooleanTotal,
                GreaterThanOrEqualDateTotal,
                GreaterThanOrEqualTimeTotal,
                GreaterThanOrEqualDatetimeTotal,
                GreaterThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public GreaterThanOrEqualTotal(GreaterThanOrEqualStringTotal value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalTotal,
                GreaterThanOrEqualStringTotal,
                GreaterThanOrEqualBooleanTotal,
                GreaterThanOrEqualDateTotal,
                GreaterThanOrEqualTimeTotal,
                GreaterThanOrEqualDatetimeTotal,
                GreaterThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public GreaterThanOrEqualTotal(GreaterThanOrEqualBooleanTotal value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalTotal,
                GreaterThanOrEqualStringTotal,
                GreaterThanOrEqualBooleanTotal,
                GreaterThanOrEqualDateTotal,
                GreaterThanOrEqualTimeTotal,
                GreaterThanOrEqualDatetimeTotal,
                GreaterThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public GreaterThanOrEqualTotal(GreaterThanOrEqualDateTotal value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalTotal,
                GreaterThanOrEqualStringTotal,
                GreaterThanOrEqualBooleanTotal,
                GreaterThanOrEqualDateTotal,
                GreaterThanOrEqualTimeTotal,
                GreaterThanOrEqualDatetimeTotal,
                GreaterThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public GreaterThanOrEqualTotal(GreaterThanOrEqualTimeTotal value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalTotal,
                GreaterThanOrEqualStringTotal,
                GreaterThanOrEqualBooleanTotal,
                GreaterThanOrEqualDateTotal,
                GreaterThanOrEqualTimeTotal,
                GreaterThanOrEqualDatetimeTotal,
                GreaterThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public GreaterThanOrEqualTotal(GreaterThanOrEqualDatetimeTotal value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalTotal,
                GreaterThanOrEqualStringTotal,
                GreaterThanOrEqualBooleanTotal,
                GreaterThanOrEqualDateTotal,
                GreaterThanOrEqualTimeTotal,
                GreaterThanOrEqualDatetimeTotal,
                GreaterThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public GreaterThanOrEqualTotal(GreaterThanOrEqualUuidTotal value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalTotal,
                GreaterThanOrEqualStringTotal,
                GreaterThanOrEqualBooleanTotal,
                GreaterThanOrEqualDateTotal,
                GreaterThanOrEqualTimeTotal,
                GreaterThanOrEqualDatetimeTotal,
                GreaterThanOrEqualUuidTotal
            >)
                value
        )
    { }

    private GreaterThanOrEqualTotal(
        OneOf<
            GreaterThanOrEqualDecimalTotal,
            GreaterThanOrEqualStringTotal,
            GreaterThanOrEqualBooleanTotal,
            GreaterThanOrEqualDateTotal,
            GreaterThanOrEqualTimeTotal,
            GreaterThanOrEqualDatetimeTotal,
            GreaterThanOrEqualUuidTotal
        > input
    )
        : base(input) { }
}
