using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class NotEqualRow
    : OneOfBase<
        NotEqualDecimalRow,
        NotEqualStringRow,
        NotEqualBooleanRow,
        NotEqualDateRow,
        NotEqualTimeRow,
        NotEqualDatetimeRow,
        NotEqualUuidRow
    >
{
    public NotEqualRow(NotEqualDecimalRow value)
        : this(
            (OneOf<
                NotEqualDecimalRow,
                NotEqualStringRow,
                NotEqualBooleanRow,
                NotEqualDateRow,
                NotEqualTimeRow,
                NotEqualDatetimeRow,
                NotEqualUuidRow
            >)
                value
        )
    { }

    public NotEqualRow(NotEqualStringRow value)
        : this(
            (OneOf<
                NotEqualDecimalRow,
                NotEqualStringRow,
                NotEqualBooleanRow,
                NotEqualDateRow,
                NotEqualTimeRow,
                NotEqualDatetimeRow,
                NotEqualUuidRow
            >)
                value
        )
    { }

    public NotEqualRow(NotEqualBooleanRow value)
        : this(
            (OneOf<
                NotEqualDecimalRow,
                NotEqualStringRow,
                NotEqualBooleanRow,
                NotEqualDateRow,
                NotEqualTimeRow,
                NotEqualDatetimeRow,
                NotEqualUuidRow
            >)
                value
        )
    { }

    public NotEqualRow(NotEqualDateRow value)
        : this(
            (OneOf<
                NotEqualDecimalRow,
                NotEqualStringRow,
                NotEqualBooleanRow,
                NotEqualDateRow,
                NotEqualTimeRow,
                NotEqualDatetimeRow,
                NotEqualUuidRow
            >)
                value
        )
    { }

    public NotEqualRow(NotEqualTimeRow value)
        : this(
            (OneOf<
                NotEqualDecimalRow,
                NotEqualStringRow,
                NotEqualBooleanRow,
                NotEqualDateRow,
                NotEqualTimeRow,
                NotEqualDatetimeRow,
                NotEqualUuidRow
            >)
                value
        )
    { }

    public NotEqualRow(NotEqualDatetimeRow value)
        : this(
            (OneOf<
                NotEqualDecimalRow,
                NotEqualStringRow,
                NotEqualBooleanRow,
                NotEqualDateRow,
                NotEqualTimeRow,
                NotEqualDatetimeRow,
                NotEqualUuidRow
            >)
                value
        )
    { }

    public NotEqualRow(NotEqualUuidRow value)
        : this(
            (OneOf<
                NotEqualDecimalRow,
                NotEqualStringRow,
                NotEqualBooleanRow,
                NotEqualDateRow,
                NotEqualTimeRow,
                NotEqualDatetimeRow,
                NotEqualUuidRow
            >)
                value
        )
    { }

    private NotEqualRow(
        OneOf<
            NotEqualDecimalRow,
            NotEqualStringRow,
            NotEqualBooleanRow,
            NotEqualDateRow,
            NotEqualTimeRow,
            NotEqualDatetimeRow,
            NotEqualUuidRow
        > input
    )
        : base(input) { }
}
