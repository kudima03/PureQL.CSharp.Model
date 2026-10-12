using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class GreaterThanOrEqualRow
    : OneOfBase<
        GreaterThanOrEqualDecimalRow,
        GreaterThanOrEqualStringRow,
        GreaterThanOrEqualBooleanRow,
        GreaterThanOrEqualDateRow,
        GreaterThanOrEqualTimeRow,
        GreaterThanOrEqualDatetimeRow,
        GreaterThanOrEqualUuidRow
    >
{
    public GreaterThanOrEqualRow(GreaterThanOrEqualDecimalRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualBooleanRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow,
                GreaterThanOrEqualUuidRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualStringRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualBooleanRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow,
                GreaterThanOrEqualUuidRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualBooleanRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualBooleanRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow,
                GreaterThanOrEqualUuidRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualDateRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualBooleanRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow,
                GreaterThanOrEqualUuidRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualTimeRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualBooleanRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow,
                GreaterThanOrEqualUuidRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualDatetimeRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualBooleanRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow,
                GreaterThanOrEqualUuidRow
            >)
                value
        )
    { }

    public GreaterThanOrEqualRow(GreaterThanOrEqualUuidRow value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalRow,
                GreaterThanOrEqualStringRow,
                GreaterThanOrEqualBooleanRow,
                GreaterThanOrEqualDateRow,
                GreaterThanOrEqualTimeRow,
                GreaterThanOrEqualDatetimeRow,
                GreaterThanOrEqualUuidRow
            >)
                value
        )
    { }

    private GreaterThanOrEqualRow(
        OneOf<
            GreaterThanOrEqualDecimalRow,
            GreaterThanOrEqualStringRow,
            GreaterThanOrEqualBooleanRow,
            GreaterThanOrEqualDateRow,
            GreaterThanOrEqualTimeRow,
            GreaterThanOrEqualDatetimeRow,
            GreaterThanOrEqualUuidRow
        > input
    )
        : base(input) { }
}
