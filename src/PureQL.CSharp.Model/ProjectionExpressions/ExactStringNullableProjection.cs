using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactStringNullableProjection
    : OneOfBase<
        FieldStringNullable,
        ParamStringNullable,
        LiteralStringNullable,
        ConcatStringNullableProjection,
        ConditionalStringNullableProjection,
        AggregateStringNullableProjection
    >
{
    public ExactStringNullableProjection(FieldStringNullable value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringNullableProjection
            >)
                value
        )
    { }

    public ExactStringNullableProjection(ParamStringNullable value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringNullableProjection
            >)
                value
        )
    { }

    public ExactStringNullableProjection(LiteralStringNullable value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringNullableProjection
            >)
                value
        )
    { }

    public ExactStringNullableProjection(ConcatStringNullableProjection value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringNullableProjection
            >)
                value
        )
    { }

    public ExactStringNullableProjection(ConditionalStringNullableProjection value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringNullableProjection
            >)
                value
        )
    { }

    public ExactStringNullableProjection(AggregateStringNullableProjection value)
        : this(
            (OneOf<
                FieldStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringNullableProjection
            >)
                value
        )
    { }

    private ExactStringNullableProjection(
        OneOf<
            FieldStringNullable,
            ParamStringNullable,
            LiteralStringNullable,
            ConcatStringNullableProjection,
            ConditionalStringNullableProjection,
            AggregateStringNullableProjection
        > input
    )
        : base(input) { }
}
