using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class EqualTotal
    : OneOfBase<
        EqualDecimalTotal,
        EqualStringTotal,
        EqualBooleanTotal,
        EqualDateTotal,
        EqualTimeTotal,
        EqualDatetimeTotal,
        EqualUuidTotal
    >
{
    public EqualTotal(EqualDecimalTotal value)
        : this(
            (OneOf<
                EqualDecimalTotal,
                EqualStringTotal,
                EqualBooleanTotal,
                EqualDateTotal,
                EqualTimeTotal,
                EqualDatetimeTotal,
                EqualUuidTotal
            >)
                value
        )
    { }

    public EqualTotal(EqualStringTotal value)
        : this(
            (OneOf<
                EqualDecimalTotal,
                EqualStringTotal,
                EqualBooleanTotal,
                EqualDateTotal,
                EqualTimeTotal,
                EqualDatetimeTotal,
                EqualUuidTotal
            >)
                value
        )
    { }

    public EqualTotal(EqualBooleanTotal value)
        : this(
            (OneOf<
                EqualDecimalTotal,
                EqualStringTotal,
                EqualBooleanTotal,
                EqualDateTotal,
                EqualTimeTotal,
                EqualDatetimeTotal,
                EqualUuidTotal
            >)
                value
        )
    { }

    public EqualTotal(EqualDateTotal value)
        : this(
            (OneOf<
                EqualDecimalTotal,
                EqualStringTotal,
                EqualBooleanTotal,
                EqualDateTotal,
                EqualTimeTotal,
                EqualDatetimeTotal,
                EqualUuidTotal
            >)
                value
        )
    { }

    public EqualTotal(EqualTimeTotal value)
        : this(
            (OneOf<
                EqualDecimalTotal,
                EqualStringTotal,
                EqualBooleanTotal,
                EqualDateTotal,
                EqualTimeTotal,
                EqualDatetimeTotal,
                EqualUuidTotal
            >)
                value
        )
    { }

    public EqualTotal(EqualDatetimeTotal value)
        : this(
            (OneOf<
                EqualDecimalTotal,
                EqualStringTotal,
                EqualBooleanTotal,
                EqualDateTotal,
                EqualTimeTotal,
                EqualDatetimeTotal,
                EqualUuidTotal
            >)
                value
        )
    { }

    public EqualTotal(EqualUuidTotal value)
        : this(
            (OneOf<
                EqualDecimalTotal,
                EqualStringTotal,
                EqualBooleanTotal,
                EqualDateTotal,
                EqualTimeTotal,
                EqualDatetimeTotal,
                EqualUuidTotal
            >)
                value
        )
    { }

    private EqualTotal(
        OneOf<
            EqualDecimalTotal,
            EqualStringTotal,
            EqualBooleanTotal,
            EqualDateTotal,
            EqualTimeTotal,
            EqualDatetimeTotal,
            EqualUuidTotal
        > input
    )
        : base(input) { }
}
