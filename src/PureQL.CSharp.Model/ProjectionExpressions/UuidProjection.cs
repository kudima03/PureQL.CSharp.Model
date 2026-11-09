using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>uuid@projection</c>.</summary>
public readonly union UuidProjection(
    IfUuidProjection,
    CoalesceUuidProjection,
    MinUuidProjection,
    MaxUuidProjection,
    LiteralUuid,
    ParamUuid,
    FieldUuid
);
