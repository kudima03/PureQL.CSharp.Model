using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ExactUuidNullableProjection
    : OneOfBase<
        FieldUuidNullable,
        ParamUuidNullable,
        LiteralUuidNullable,
        ConditionalUuidNullableProjection,
        AggregateUuidNullableProjection
    >
{
    public ExactUuidNullableProjection(FieldUuidNullable value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableProjection,
                AggregateUuidNullableProjection
            >)
                value
        )
    { }

    public ExactUuidNullableProjection(ParamUuidNullable value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableProjection,
                AggregateUuidNullableProjection
            >)
                value
        )
    { }

    public ExactUuidNullableProjection(LiteralUuidNullable value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableProjection,
                AggregateUuidNullableProjection
            >)
                value
        )
    { }

    public ExactUuidNullableProjection(ConditionalUuidNullableProjection value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableProjection,
                AggregateUuidNullableProjection
            >)
                value
        )
    { }

    public ExactUuidNullableProjection(AggregateUuidNullableProjection value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableProjection,
                AggregateUuidNullableProjection
            >)
                value
        )
    { }

    private ExactUuidNullableProjection(
        OneOf<
            FieldUuidNullable,
            ParamUuidNullable,
            LiteralUuidNullable,
            ConditionalUuidNullableProjection,
            AggregateUuidNullableProjection
        > input
    )
        : base(input) { }
}
