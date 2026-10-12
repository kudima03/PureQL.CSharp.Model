using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class GreaterThanRow
    : OneOfBase<
        GreaterThanDecimalRow,
        GreaterThanStringRow,
        GreaterThanBooleanRow,
        GreaterThanDateRow,
        GreaterThanTimeRow,
        GreaterThanDatetimeRow,
        GreaterThanUuidRow
    >
{
    public GreaterThanRow(GreaterThanDecimalRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanBooleanRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow,
                GreaterThanUuidRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanStringRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanBooleanRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow,
                GreaterThanUuidRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanBooleanRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanBooleanRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow,
                GreaterThanUuidRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanDateRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanBooleanRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow,
                GreaterThanUuidRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanTimeRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanBooleanRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow,
                GreaterThanUuidRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanDatetimeRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanBooleanRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow,
                GreaterThanUuidRow
            >)
                value
        )
    { }

    public GreaterThanRow(GreaterThanUuidRow value)
        : this(
            (OneOf<
                GreaterThanDecimalRow,
                GreaterThanStringRow,
                GreaterThanBooleanRow,
                GreaterThanDateRow,
                GreaterThanTimeRow,
                GreaterThanDatetimeRow,
                GreaterThanUuidRow
            >)
                value
        )
    { }

    private GreaterThanRow(
        OneOf<
            GreaterThanDecimalRow,
            GreaterThanStringRow,
            GreaterThanBooleanRow,
            GreaterThanDateRow,
            GreaterThanTimeRow,
            GreaterThanDatetimeRow,
            GreaterThanUuidRow
        > input
    )
        : base(input) { }
}
