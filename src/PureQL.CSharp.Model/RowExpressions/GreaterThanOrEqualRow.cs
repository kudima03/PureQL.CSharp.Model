using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class GreaterThanOrEqualRow
    : OneOfBase<
        GreaterThanOrEqualDecimalRow,
        GreaterThanOrEqualStringRow,
        GreaterThanOrEqualDateRow,
        GreaterThanOrEqualTimeRow,
        GreaterThanOrEqualDatetimeRow
    >
{
    public GreaterThanOrEqualRow(GreaterThanOrEqualDecimalRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualStringRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualDateRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualTimeRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualDatetimeRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    private GreaterThanOrEqualRow(
        OneOf<
            GreaterThanOrEqualDecimalRow,
            GreaterThanOrEqualStringRow,
            GreaterThanOrEqualDateRow,
            GreaterThanOrEqualTimeRow,
            GreaterThanOrEqualDatetimeRow
        > input
    )
        : base(input) { }
}
