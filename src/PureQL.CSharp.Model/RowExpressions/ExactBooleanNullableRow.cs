using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactBooleanNullableRow
    : OneOfBase<
        FieldBooleanNullable,
        ParamBooleanNullable,
        LiteralBooleanNullable,
        ConditionalBooleanNullableRow
    >
{
    public ExactBooleanNullableRow(FieldBooleanNullable value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    public ExactBooleanNullableRow(ParamBooleanNullable value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    public ExactBooleanNullableRow(LiteralBooleanNullable value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    public ExactBooleanNullableRow(ConditionalBooleanNullableRow value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    private ExactBooleanNullableRow(
        OneOf<
            FieldBooleanNullable,
            ParamBooleanNullable,
            LiteralBooleanNullable,
            ConditionalBooleanNullableRow
        > input
    )
        : base(input) { }
}
