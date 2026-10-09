using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class GreaterThanRow
    : OneOfBase<
        GreaterThanDecimalRow,
        GreaterThanStringRow,
        GreaterThanDateRow,
        GreaterThanTimeRow,
        GreaterThanDatetimeRow
    >
{
    public GreaterThanRow(GreaterThanDecimalRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanStringRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanDateRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanTimeRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanDatetimeRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow
            >)
                value
        )
    { }

    private GreaterThanRow(
        OneOf<
            GreaterThanDecimalRow,
            GreaterThanStringRow,
            GreaterThanDateRow,
            GreaterThanTimeRow,
            GreaterThanDatetimeRow
        > input
    )
        : base(input) { }
}
