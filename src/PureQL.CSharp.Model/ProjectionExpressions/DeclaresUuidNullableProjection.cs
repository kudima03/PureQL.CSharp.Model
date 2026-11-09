using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.uuid.nullable@projection</c>.</summary>
public readonly union DeclaresUuidNullableProjection(
    IfUuidNullableProjection,
    CoalesceUuidNullableProjection,
    MinUuidNullableProjection,
    MaxUuidNullableProjection,
    LiteralUuidNullable,
    ParamUuidNullable,
    FieldUuidNullable
);
