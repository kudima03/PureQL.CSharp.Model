using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>time.nullable@projection</c>.</summary>
public readonly union TimeNullableProjection(
    TimeAddSecondsTimeProjection,
    IfTimeProjection,
    CoalesceTimeProjection,
    AverageTimeProjection,
    MinTimeProjection,
    MaxTimeProjection,
    LiteralTime,
    ParamTime,
    FieldTime,
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
