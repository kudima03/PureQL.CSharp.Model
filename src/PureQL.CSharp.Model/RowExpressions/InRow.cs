using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class InRow
    : OneOfBase<
        InDecimalRow,
        InStringRow,
        InBooleanRow,
        InDateRow,
        InTimeRow,
        InDatetimeRow,
        InUuidRow
    >
{
    public InRow(InDecimalRow value)
        : this(
            (OneOf<
                InDecimalRow,
                InStringRow,
                InBooleanRow,
                InDateRow,
                InTimeRow,
                InDatetimeRow,
                InUuidRow
            >)
                value
        )
    { }

    public InRow(InStringRow value)
        : this(
            (OneOf<
                InDecimalRow,
                InStringRow,
                InBooleanRow,
                InDateRow,
                InTimeRow,
                InDatetimeRow,
                InUuidRow
            >)
                value
        )
    { }

    public InRow(InBooleanRow value)
        : this(
            (OneOf<
                InDecimalRow,
                InStringRow,
                InBooleanRow,
                InDateRow,
                InTimeRow,
                InDatetimeRow,
                InUuidRow
            >)
                value
        )
    { }

    public InRow(InDateRow value)
        : this(
            (OneOf<
                InDecimalRow,
                InStringRow,
                InBooleanRow,
                InDateRow,
                InTimeRow,
                InDatetimeRow,
                InUuidRow
            >)
                value
        )
    { }

    public InRow(InTimeRow value)
        : this(
            (OneOf<
                InDecimalRow,
                InStringRow,
                InBooleanRow,
                InDateRow,
                InTimeRow,
                InDatetimeRow,
                InUuidRow
            >)
                value
        )
    { }

    public InRow(InDatetimeRow value)
        : this(
            (OneOf<
                InDecimalRow,
                InStringRow,
                InBooleanRow,
                InDateRow,
                InTimeRow,
                InDatetimeRow,
                InUuidRow
            >)
                value
        )
    { }

    public InRow(InUuidRow value)
        : this(
            (OneOf<
                InDecimalRow,
                InStringRow,
                InBooleanRow,
                InDateRow,
                InTimeRow,
                InDatetimeRow,
                InUuidRow
            >)
                value
        )
    { }

    private InRow(
        OneOf<
            InDecimalRow,
            InStringRow,
            InBooleanRow,
            InDateRow,
            InTimeRow,
            InDatetimeRow,
            InUuidRow
        > input
    )
        : base(input) { }
}
