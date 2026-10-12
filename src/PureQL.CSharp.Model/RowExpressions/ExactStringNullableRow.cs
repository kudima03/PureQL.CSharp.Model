using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactStringNullableRow
    : OneOfBase<
        FieldStringNullable,
        ParamStringNullable,
        LiteralStringNullable,
        ConcatStringNullableRow,
        ConditionalStringNullableRow
    >
{
    public ExactStringNullableRow(FieldStringNullable value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    public ExactStringNullableRow(ParamStringNullable value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    public ExactStringNullableRow(LiteralStringNullable value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    public ExactStringNullableRow(ConcatStringNullableRow value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    public ExactStringNullableRow(ConditionalStringNullableRow value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    private ExactStringNullableRow(
        OneOf<
            FieldStringNullable,
            ParamStringNullable,
            LiteralStringNullable,
            ConcatStringNullableRow,
            ConditionalStringNullableRow
        > input
    )
        : base(input) { }
}
