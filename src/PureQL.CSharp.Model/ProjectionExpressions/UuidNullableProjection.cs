using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>uuid.nullable@projection</c>.</summary>
public readonly union UuidNullableProjection(
    IfUuidProjection,
    CoalesceUuidProjection,
    MinUuidProjection,
    MaxUuidProjection,
    LiteralUuid,
    ParamUuid,
    FieldUuid,
    IfUuidNullableProjection,
    CoalesceUuidNullableProjection,
    MinUuidNullableProjection,
    MaxUuidNullableProjection,
    LiteralUuidNullable,
    ParamUuidNullable,
    FieldUuidNullable
);
