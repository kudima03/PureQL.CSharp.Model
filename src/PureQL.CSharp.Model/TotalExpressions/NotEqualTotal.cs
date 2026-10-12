using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class NotEqualTotal
    : OneOfBase<
        NotEqualDecimalTotal,
        NotEqualStringTotal,
        NotEqualBooleanTotal,
        NotEqualDateTotal,
        NotEqualTimeTotal,
        NotEqualDatetimeTotal,
        NotEqualUuidTotal
    >
{
    public NotEqualTotal(NotEqualDecimalTotal value)
        : this(
            (OneOf<
                NotEqualDecimalTotal,
                NotEqualStringTotal,
                NotEqualBooleanTotal,
                NotEqualDateTotal,
                NotEqualTimeTotal,
                NotEqualDatetimeTotal,
                NotEqualUuidTotal
            >)
                value
        )
    { }

    public NotEqualTotal(NotEqualStringTotal value)
        : this(
            (OneOf<
                NotEqualDecimalTotal,
                NotEqualStringTotal,
                NotEqualBooleanTotal,
                NotEqualDateTotal,
                NotEqualTimeTotal,
                NotEqualDatetimeTotal,
                NotEqualUuidTotal
            >)
                value
        )
    { }

    public NotEqualTotal(NotEqualBooleanTotal value)
        : this(
            (OneOf<
                NotEqualDecimalTotal,
                NotEqualStringTotal,
                NotEqualBooleanTotal,
                NotEqualDateTotal,
                NotEqualTimeTotal,
                NotEqualDatetimeTotal,
                NotEqualUuidTotal
            >)
                value
        )
    { }

    public NotEqualTotal(NotEqualDateTotal value)
        : this(
            (OneOf<
                NotEqualDecimalTotal,
                NotEqualStringTotal,
                NotEqualBooleanTotal,
                NotEqualDateTotal,
                NotEqualTimeTotal,
                NotEqualDatetimeTotal,
                NotEqualUuidTotal
            >)
                value
        )
    { }

    public NotEqualTotal(NotEqualTimeTotal value)
        : this(
            (OneOf<
                NotEqualDecimalTotal,
                NotEqualStringTotal,
                NotEqualBooleanTotal,
                NotEqualDateTotal,
                NotEqualTimeTotal,
                NotEqualDatetimeTotal,
                NotEqualUuidTotal
            >)
                value
        )
    { }

    public NotEqualTotal(NotEqualDatetimeTotal value)
        : this(
            (OneOf<
                NotEqualDecimalTotal,
                NotEqualStringTotal,
                NotEqualBooleanTotal,
                NotEqualDateTotal,
                NotEqualTimeTotal,
                NotEqualDatetimeTotal,
                NotEqualUuidTotal
            >)
                value
        )
    { }

    public NotEqualTotal(NotEqualUuidTotal value)
        : this(
            (OneOf<
                NotEqualDecimalTotal,
                NotEqualStringTotal,
                NotEqualBooleanTotal,
                NotEqualDateTotal,
                NotEqualTimeTotal,
                NotEqualDatetimeTotal,
                NotEqualUuidTotal
            >)
                value
        )
    { }

    private NotEqualTotal(
        OneOf<
            NotEqualDecimalTotal,
            NotEqualStringTotal,
            NotEqualBooleanTotal,
            NotEqualDateTotal,
            NotEqualTimeTotal,
            NotEqualDatetimeTotal,
            NotEqualUuidTotal
        > input
    )
        : base(input) { }
}
