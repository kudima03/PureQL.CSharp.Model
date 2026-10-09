using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class UuidProjection
    : OneOfBase<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidProjection>
{
    public UuidProjection(FieldUuid value)
        : this((OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidProjection>)value)
    { }

    public UuidProjection(ParamUuid value)
        : this((OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidProjection>)value)
    { }

    public UuidProjection(LiteralUuid value)
        : this((OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidProjection>)value)
    { }

    public UuidProjection(ConditionalUuidProjection value)
        : this((OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidProjection>)value)
    { }

    private UuidProjection(
        OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidProjection> input
    )
        : base(input) { }
}
