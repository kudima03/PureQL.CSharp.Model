using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.time.nullable@projection</c>.</summary>
public readonly union DeclaresTimeNullableProjection(
    TimeAddSecondsTimeNullableProjection,
    IfTimeNullableProjection,
    CoalesceTimeNullableProjection,
    AverageTimeNullableProjection,
    MinTimeNullableProjection,
    MaxTimeNullableProjection,
    LiteralTimeNullable,
    ParamTimeNullable,
    FieldTimeNullable
);
