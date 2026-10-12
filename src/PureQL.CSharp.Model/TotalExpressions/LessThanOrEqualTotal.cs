using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class LessThanOrEqualTotal
    : OneOfBase<
        LessThanOrEqualDecimalTotal,
        LessThanOrEqualStringTotal,
        LessThanOrEqualBooleanTotal,
        LessThanOrEqualDateTotal,
        LessThanOrEqualTimeTotal,
        LessThanOrEqualDatetimeTotal,
        LessThanOrEqualUuidTotal
    >
{
    public LessThanOrEqualTotal(LessThanOrEqualDecimalTotal value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalTotal,
                LessThanOrEqualStringTotal,
                LessThanOrEqualBooleanTotal,
                LessThanOrEqualDateTotal,
                LessThanOrEqualTimeTotal,
                LessThanOrEqualDatetimeTotal,
                LessThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public LessThanOrEqualTotal(LessThanOrEqualStringTotal value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalTotal,
                LessThanOrEqualStringTotal,
                LessThanOrEqualBooleanTotal,
                LessThanOrEqualDateTotal,
                LessThanOrEqualTimeTotal,
                LessThanOrEqualDatetimeTotal,
                LessThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public LessThanOrEqualTotal(LessThanOrEqualBooleanTotal value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalTotal,
                LessThanOrEqualStringTotal,
                LessThanOrEqualBooleanTotal,
                LessThanOrEqualDateTotal,
                LessThanOrEqualTimeTotal,
                LessThanOrEqualDatetimeTotal,
                LessThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public LessThanOrEqualTotal(LessThanOrEqualDateTotal value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalTotal,
                LessThanOrEqualStringTotal,
                LessThanOrEqualBooleanTotal,
                LessThanOrEqualDateTotal,
                LessThanOrEqualTimeTotal,
                LessThanOrEqualDatetimeTotal,
                LessThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public LessThanOrEqualTotal(LessThanOrEqualTimeTotal value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalTotal,
                LessThanOrEqualStringTotal,
                LessThanOrEqualBooleanTotal,
                LessThanOrEqualDateTotal,
                LessThanOrEqualTimeTotal,
                LessThanOrEqualDatetimeTotal,
                LessThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public LessThanOrEqualTotal(LessThanOrEqualDatetimeTotal value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalTotal,
                LessThanOrEqualStringTotal,
                LessThanOrEqualBooleanTotal,
                LessThanOrEqualDateTotal,
                LessThanOrEqualTimeTotal,
                LessThanOrEqualDatetimeTotal,
                LessThanOrEqualUuidTotal
            >)
                value
        )
    { }

    public LessThanOrEqualTotal(LessThanOrEqualUuidTotal value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalTotal,
                LessThanOrEqualStringTotal,
                LessThanOrEqualBooleanTotal,
                LessThanOrEqualDateTotal,
                LessThanOrEqualTimeTotal,
                LessThanOrEqualDatetimeTotal,
                LessThanOrEqualUuidTotal
            >)
                value
        )
    { }

    private LessThanOrEqualTotal(
        OneOf<
            LessThanOrEqualDecimalTotal,
            LessThanOrEqualStringTotal,
            LessThanOrEqualBooleanTotal,
            LessThanOrEqualDateTotal,
            LessThanOrEqualTimeTotal,
            LessThanOrEqualDatetimeTotal,
            LessThanOrEqualUuidTotal
        > input
    )
        : base(input) { }
}
