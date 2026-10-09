using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class LessThanOrEqualRow
    : OneOfBase<
        LessThanOrEqualDecimalRow,
        LessThanOrEqualStringRow,
        LessThanOrEqualDateRow,
        LessThanOrEqualTimeRow,
        LessThanOrEqualDatetimeRow
    >
{
    public LessThanOrEqualRow(LessThanOrEqualDecimalRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualStringRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualDateRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualTimeRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualDatetimeRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow
            >)
                value
        )
    { }

    private LessThanOrEqualRow(
        OneOf<
            LessThanOrEqualDecimalRow,
            LessThanOrEqualStringRow,
            LessThanOrEqualDateRow,
            LessThanOrEqualTimeRow,
            LessThanOrEqualDatetimeRow
        > input
    )
        : base(input) { }
}
