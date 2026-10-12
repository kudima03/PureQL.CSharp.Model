using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactBooleanNullableProjection
    : OneOfBase<
        FieldBooleanNullable,
        ParamBooleanNullable,
        LiteralBooleanNullable,
        ConditionalBooleanNullableProjection,
        AggregateBooleanNullableProjection
    >
{
    public ExactBooleanNullableProjection(FieldBooleanNullable value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableProjection,
                AggregateBooleanNullableProjection
            >)
                value
        )
    { }

    public ExactBooleanNullableProjection(ParamBooleanNullable value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableProjection,
                AggregateBooleanNullableProjection
            >)
                value
        )
    { }

    public ExactBooleanNullableProjection(LiteralBooleanNullable value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableProjection,
                AggregateBooleanNullableProjection
            >)
                value
        )
    { }

    public ExactBooleanNullableProjection(ConditionalBooleanNullableProjection value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableProjection,
                AggregateBooleanNullableProjection
            >)
                value
        )
    { }

    public ExactBooleanNullableProjection(AggregateBooleanNullableProjection value)
        : this(
            (OneOf<
                FieldBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableProjection,
                AggregateBooleanNullableProjection
            >)
                value
        )
    { }

    private ExactBooleanNullableProjection(
        OneOf<
            FieldBooleanNullable,
            ParamBooleanNullable,
            LiteralBooleanNullable,
            ConditionalBooleanNullableProjection,
            AggregateBooleanNullableProjection
        > input
    )
        : base(input) { }
}
