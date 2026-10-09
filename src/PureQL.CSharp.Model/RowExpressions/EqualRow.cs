using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class EqualRow
    : OneOfBase<
        EqualDecimalRow,
        EqualStringRow,
        EqualBooleanRow,
        EqualDateRow,
        EqualTimeRow,
        EqualDatetimeRow,
        EqualUuidRow
    >
{
    public EqualRow(EqualDecimalRow value)
        : this(
            (OneOf<
                EqualDecimalRow,
                EqualStringRow,
                EqualBooleanRow,
                EqualDateRow,
                EqualTimeRow,
                EqualDatetimeRow,
                EqualUuidRow
            >)
                value
        )
    { }

    public EqualRow(EqualStringRow value)
        : this(
            (OneOf<
                EqualDecimalRow,
                EqualStringRow,
                EqualBooleanRow,
                EqualDateRow,
                EqualTimeRow,
                EqualDatetimeRow,
                EqualUuidRow
            >)
                value
        )
    { }

    public EqualRow(EqualBooleanRow value)
        : this(
            (OneOf<
                EqualDecimalRow,
                EqualStringRow,
                EqualBooleanRow,
                EqualDateRow,
                EqualTimeRow,
                EqualDatetimeRow,
                EqualUuidRow
            >)
                value
        )
    { }

    public EqualRow(EqualDateRow value)
        : this(
            (OneOf<
                EqualDecimalRow,
                EqualStringRow,
                EqualBooleanRow,
                EqualDateRow,
                EqualTimeRow,
                EqualDatetimeRow,
                EqualUuidRow
            >)
                value
        )
    { }

    public EqualRow(EqualTimeRow value)
        : this(
            (OneOf<
                EqualDecimalRow,
                EqualStringRow,
                EqualBooleanRow,
                EqualDateRow,
                EqualTimeRow,
                EqualDatetimeRow,
                EqualUuidRow
            >)
                value
        )
    { }

    public EqualRow(EqualDatetimeRow value)
        : this(
            (OneOf<
                EqualDecimalRow,
                EqualStringRow,
                EqualBooleanRow,
                EqualDateRow,
                EqualTimeRow,
                EqualDatetimeRow,
                EqualUuidRow
            >)
                value
        )
    { }

    public EqualRow(EqualUuidRow value)
        : this(
            (OneOf<
                EqualDecimalRow,
                EqualStringRow,
                EqualBooleanRow,
                EqualDateRow,
                EqualTimeRow,
                EqualDatetimeRow,
                EqualUuidRow
            >)
                value
        )
    { }

    private EqualRow(
        OneOf<
            EqualDecimalRow,
            EqualStringRow,
            EqualBooleanRow,
            EqualDateRow,
            EqualTimeRow,
            EqualDatetimeRow,
            EqualUuidRow
        > input
    )
        : base(input) { }
}
