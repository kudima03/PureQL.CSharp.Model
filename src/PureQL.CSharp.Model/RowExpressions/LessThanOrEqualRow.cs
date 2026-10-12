using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class LessThanOrEqualRow
    : OneOfBase<
        LessThanOrEqualDecimalRow,
        LessThanOrEqualStringRow,
        LessThanOrEqualBooleanRow,
        LessThanOrEqualDateRow,
        LessThanOrEqualTimeRow,
        LessThanOrEqualDatetimeRow,
        LessThanOrEqualUuidRow
    >
{
    public LessThanOrEqualRow(LessThanOrEqualDecimalRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualBooleanRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow,
                LessThanOrEqualUuidRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualStringRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualBooleanRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow,
                LessThanOrEqualUuidRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualBooleanRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualBooleanRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow,
                LessThanOrEqualUuidRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualDateRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualBooleanRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow,
                LessThanOrEqualUuidRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualTimeRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualBooleanRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow,
                LessThanOrEqualUuidRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualDatetimeRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualBooleanRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow,
                LessThanOrEqualUuidRow
            >)
                value
        )
    { }

    public LessThanOrEqualRow(LessThanOrEqualUuidRow value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalRow,
                LessThanOrEqualStringRow,
                LessThanOrEqualBooleanRow,
                LessThanOrEqualDateRow,
                LessThanOrEqualTimeRow,
                LessThanOrEqualDatetimeRow,
                LessThanOrEqualUuidRow
            >)
                value
        )
    { }

    private LessThanOrEqualRow(
        OneOf<
            LessThanOrEqualDecimalRow,
            LessThanOrEqualStringRow,
            LessThanOrEqualBooleanRow,
            LessThanOrEqualDateRow,
            LessThanOrEqualTimeRow,
            LessThanOrEqualDatetimeRow,
            LessThanOrEqualUuidRow
        > input
    )
        : base(input) { }
}
