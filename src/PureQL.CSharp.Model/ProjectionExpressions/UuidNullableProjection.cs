using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>uuid.nullable@projection</c>.</summary>
public readonly union UuidNullableProjection(
    AsUuidUuidProjection,
    IfUuidProjection,
    CoalesceUuidProjection,
    GreatestUuidProjection,
    LeastUuidProjection,
    MinUuidProjection,
    MaxUuidProjection,
    FirstUuidProjection,
    LastUuidProjection,
    PercentileDiscreteUuidProjection,
    ModeUuidProjection,
    PreviousUuidProjection,
    NextUuidProjection,
    LiteralUuid,
    ParamUuid,
    FieldUuid,
    AsUuidUuidNullableProjection,
    AsNullableUuidNullableProjection,
    TryAsUuidProjection,
    IfUuidNullableProjection,
    CoalesceUuidNullableProjection,
    NullIfEqualUuidNullableProjection,
    GreatestUuidNullableProjection,
    LeastUuidNullableProjection,
    MinUuidNullableProjection,
    MaxUuidNullableProjection,
    FirstUuidNullableProjection,
    LastUuidNullableProjection,
    PercentileDiscreteUuidNullableProjection,
    ModeUuidNullableProjection,
    PreviousUuidNullableProjection,
    NextUuidNullableProjection,
    LiteralUuidNullable,
    ParamUuidNullable,
    FieldUuidNullable
);
