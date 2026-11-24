using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.uuid.nullable@projection</c>.</summary>
public readonly union DeclaresUuidNullableProjection(
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
