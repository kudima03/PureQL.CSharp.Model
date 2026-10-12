using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class UuidProjection
    : OneOfBase<
        FieldUuid,
        ParamUuid,
        LiteralUuid,
        ConditionalUuidProjection,
        AggregateUuidProjection
    >
{
    public UuidProjection(FieldUuid value)
        : this(
            (OneOf<
                FieldUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidProjection,
                AggregateUuidProjection
            >)
                value
        )
    { }

    public UuidProjection(ParamUuid value)
        : this(
            (OneOf<
                FieldUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidProjection,
                AggregateUuidProjection
            >)
                value
        )
    { }

    public UuidProjection(LiteralUuid value)
        : this(
            (OneOf<
                FieldUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidProjection,
                AggregateUuidProjection
            >)
                value
        )
    { }

    public UuidProjection(ConditionalUuidProjection value)
        : this(
            (OneOf<
                FieldUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidProjection,
                AggregateUuidProjection
            >)
                value
        )
    { }

    public UuidProjection(AggregateUuidProjection value)
        : this(
            (OneOf<
                FieldUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidProjection,
                AggregateUuidProjection
            >)
                value
        )
    { }

    private UuidProjection(
        OneOf<
            FieldUuid,
            ParamUuid,
            LiteralUuid,
            ConditionalUuidProjection,
            AggregateUuidProjection
        > input
    )
        : base(input) { }
}
