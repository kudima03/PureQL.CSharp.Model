using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.time.nullable@projection</c>.</summary>
public readonly union DeclaresTimeNullableProjection(
    TimeAddSecondsTimeNullableProjection,
    TimeFromPartsTimeNullableProjection,
    StartOfHourTimeNullableProjection,
    StartOfMinuteTimeNullableProjection,
    StartOfSecondTimeNullableProjection,
    AsTimeDatetimeTimeNullableProjection,
    AsTimeStringTimeNullableProjection,
    AsNullableTimeNullableProjection,
    TryAsTimeProjection,
    IfTimeNullableProjection,
    CoalesceTimeNullableProjection,
    NullIfEqualTimeNullableProjection,
    GreatestTimeNullableProjection,
    LeastTimeNullableProjection,
    AverageTimeNullableProjection,
    MinTimeNullableProjection,
    MaxTimeNullableProjection,
    FirstTimeNullableProjection,
    LastTimeNullableProjection,
    MedianTimeNullableProjection,
    PercentileContinuousTimeNullableProjection,
    PercentileDiscreteTimeNullableProjection,
    ModeTimeNullableProjection,
    PreviousTimeNullableProjection,
    NextTimeNullableProjection,
    LiteralTimeNullable,
    ParamTimeNullable,
    FieldTimeNullable
);
