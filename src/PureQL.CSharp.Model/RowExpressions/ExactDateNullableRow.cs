using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactDateNullableRow
    : OneOfBase<
        FieldDateNullable,
        ParamDateNullable,
        LiteralDateNullable,
        DateAddDaysDateNullableRow,
        ConditionalDateNullableRow
    >
{
    public ExactDateNullableRow(FieldDateNullable value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    public ExactDateNullableRow(ParamDateNullable value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    public ExactDateNullableRow(LiteralDateNullable value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    public ExactDateNullableRow(DateAddDaysDateNullableRow value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    public ExactDateNullableRow(ConditionalDateNullableRow value)
        : this(
            (OneOf<
                FieldDateNullable,
                ParamDateNullable,
                LiteralDateNullable,
                DateAddDaysDateNullableRow,
                ConditionalDateNullableRow
            >)
                value
        )
    { }

    private ExactDateNullableRow(
        OneOf<
            FieldDateNullable,
            ParamDateNullable,
            LiteralDateNullable,
            DateAddDaysDateNullableRow,
            ConditionalDateNullableRow
        > input
    )
        : base(input) { }
}
