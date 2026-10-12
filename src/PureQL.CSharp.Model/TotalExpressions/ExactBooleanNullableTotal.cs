using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactBooleanNullableTotal
    : OneOfBase<
        ParamBooleanNullable,
        LiteralBooleanNullable,
        ConditionalBooleanNullableTotal,
        AggregateBooleanNullableTotal
    >
{
    public ExactBooleanNullableTotal(ParamBooleanNullable value)
        : this(
            (OneOf<
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableTotal,
                AggregateBooleanNullableTotal
            >)
                value
        )
    { }

    public ExactBooleanNullableTotal(LiteralBooleanNullable value)
        : this(
            (OneOf<
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableTotal,
                AggregateBooleanNullableTotal
            >)
                value
        )
    { }

    public ExactBooleanNullableTotal(ConditionalBooleanNullableTotal value)
        : this(
            (OneOf<
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableTotal,
                AggregateBooleanNullableTotal
            >)
                value
        )
    { }

    public ExactBooleanNullableTotal(AggregateBooleanNullableTotal value)
        : this(
            (OneOf<
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableTotal,
                AggregateBooleanNullableTotal
            >)
                value
        )
    { }

    private ExactBooleanNullableTotal(
        OneOf<
            ParamBooleanNullable,
            LiteralBooleanNullable,
            ConditionalBooleanNullableTotal,
            AggregateBooleanNullableTotal
        > input
    )
        : base(input) { }
}
