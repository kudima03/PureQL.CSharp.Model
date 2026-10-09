using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class LessThanRow
    : OneOfBase<
        LessThanDecimalRow,
        LessThanStringRow,
        LessThanDateRow,
        LessThanTimeRow,
        LessThanDatetimeRow
    >
{
    public LessThanRow(LessThanDecimalRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanStringRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanDateRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanTimeRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanDatetimeRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow
            >)
                value
        )
    { }

    private LessThanRow(
        OneOf<
            LessThanDecimalRow,
            LessThanStringRow,
            LessThanDateRow,
            LessThanTimeRow,
            LessThanDatetimeRow
        > input
    )
        : base(input) { }
}
