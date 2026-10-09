using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DateNullableRow
    : OneOfBase<
        FieldAsDateNullable,
        ParamAsDateNullable,
        LiteralAsDateNullable,
        DateAddDaysDateNullableRow,
        ConditionalDateNullableRow
    >
{
    public DateNullableRow(FieldAsDateNullable value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    public DateNullableRow(ParamAsDateNullable value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    public DateNullableRow(LiteralAsDateNullable value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    public DateNullableRow(DateAddDaysDateNullableRow value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    public DateNullableRow(ConditionalDateNullableRow value)
        : this(
            (OneOf<
                FieldAsDateNullable,
                ParamAsDateNullable,
                LiteralAsDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    private DateNullableRow(
        OneOf<
            FieldAsDateNullable,
            ParamAsDateNullable,
            LiteralAsDateNullable,
            DateAddDaysDateNullableRow,
            ConditionalDateNullableRow
        > input
    )
        : base(input) { }
}
