using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ExactStringNullableTotal
    : OneOfBase<
        ParamStringNullable,
        LiteralStringNullable,
        ConcatStringNullableTotal,
        ConditionalStringNullableTotal,
        AggregateStringNullableTotal
    >
{
    public ExactStringNullableTotal(ParamStringNullable value)
        : this(
            (OneOf<
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableTotal,
                ConditionalStringNullableTotal,
                AggregateStringNullableTotal
            >)
                value
        )
    { }

    public ExactStringNullableTotal(LiteralStringNullable value)
        : this(
            (OneOf<
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableTotal,
                ConditionalStringNullableTotal,
                AggregateStringNullableTotal
            >)
                value
        )
    { }

    public ExactStringNullableTotal(ConcatStringNullableTotal value)
        : this(
            (OneOf<
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableTotal,
                ConditionalStringNullableTotal,
                AggregateStringNullableTotal
            >)
                value
        )
    { }

    public ExactStringNullableTotal(ConditionalStringNullableTotal value)
        : this(
            (OneOf<
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableTotal,
                ConditionalStringNullableTotal,
                AggregateStringNullableTotal
            >)
                value
        )
    { }

    public ExactStringNullableTotal(AggregateStringNullableTotal value)
        : this(
            (OneOf<
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableTotal,
                ConditionalStringNullableTotal,
                AggregateStringNullableTotal
            >)
                value
        )
    { }

    private ExactStringNullableTotal(
        OneOf<
            ParamStringNullable,
            LiteralStringNullable,
            ConcatStringNullableTotal,
            ConditionalStringNullableTotal,
            AggregateStringNullableTotal
        > input
    )
        : base(input) { }
}
