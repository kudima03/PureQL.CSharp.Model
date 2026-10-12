using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class LessThanRow
    : OneOfBase<
        LessThanDecimalRow,
        LessThanStringRow,
        LessThanBooleanRow,
        LessThanDateRow,
        LessThanTimeRow,
        LessThanDatetimeRow,
        LessThanUuidRow
    >
{
    public LessThanRow(LessThanDecimalRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanBooleanRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow,
                LessThanUuidRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanStringRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanBooleanRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow,
                LessThanUuidRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanBooleanRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanBooleanRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow,
                LessThanUuidRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanDateRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanBooleanRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow,
                LessThanUuidRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanTimeRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanBooleanRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow,
                LessThanUuidRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanDatetimeRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanBooleanRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow,
                LessThanUuidRow
            >)
                value
        )
    { }

    public LessThanRow(LessThanUuidRow value)
        : this(
            (OneOf<
                LessThanDecimalRow,
                LessThanStringRow,
                LessThanBooleanRow,
                LessThanDateRow,
                LessThanTimeRow,
                LessThanDatetimeRow,
                LessThanUuidRow
            >)
                value
        )
    { }

    private LessThanRow(
        OneOf<
            LessThanDecimalRow,
            LessThanStringRow,
            LessThanBooleanRow,
            LessThanDateRow,
            LessThanTimeRow,
            LessThanDatetimeRow,
            LessThanUuidRow
        > input
    )
        : base(input) { }
}
