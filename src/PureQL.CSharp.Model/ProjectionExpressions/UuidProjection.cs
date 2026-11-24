using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>uuid@projection</c>.</summary>
public readonly union UuidProjection(
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
    FieldUuid
);
