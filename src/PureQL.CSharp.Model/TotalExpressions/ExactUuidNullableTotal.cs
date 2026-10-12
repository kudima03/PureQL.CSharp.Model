using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactUuidNullableTotal
    : OneOfBase<
        ParamUuidNullable,
        LiteralUuidNullable,
        ConditionalUuidNullableTotal,
        AggregateUuidNullableTotal
    >
{
    public ExactUuidNullableTotal(ParamUuidNullable value)
        : this(
            (OneOf<
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableTotal,
                AggregateUuidNullableTotal
            >)
                value
        )
    { }

    public ExactUuidNullableTotal(LiteralUuidNullable value)
        : this(
            (OneOf<
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableTotal,
                AggregateUuidNullableTotal
            >)
                value
        )
    { }

    public ExactUuidNullableTotal(ConditionalUuidNullableTotal value)
        : this(
            (OneOf<
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableTotal,
                AggregateUuidNullableTotal
            >)
                value
        )
    { }

    public ExactUuidNullableTotal(AggregateUuidNullableTotal value)
        : this(
            (OneOf<
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableTotal,
                AggregateUuidNullableTotal
            >)
                value
        )
    { }

    private ExactUuidNullableTotal(
        OneOf<
            ParamUuidNullable,
            LiteralUuidNullable,
            ConditionalUuidNullableTotal,
            AggregateUuidNullableTotal
        > input
    )
        : base(input) { }
}
