using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.time.nullable@total</c>.</summary>
public readonly union DeclaresTimeNullableTotal(
    TimeAddSecondsTimeNullableTotal,
    TimeFromPartsTimeNullableTotal,
    StartOfHourTimeNullableTotal,
    StartOfMinuteTimeNullableTotal,
    StartOfSecondTimeNullableTotal,
    AsTimeDatetimeTimeNullableTotal,
    AsTimeStringTimeNullableTotal,
    AsNullableTimeNullableTotal,
    TryAsTimeTotal,
    IfTimeNullableTotal,
    CoalesceTimeNullableTotal,
    NullIfEqualTimeNullableTotal,
    GreatestTimeNullableTotal,
    LeastTimeNullableTotal,
    AverageTimeNullableTotal,
    MinTimeNullableTotal,
    MaxTimeNullableTotal,
    FirstTimeNullableTotal,
    LastTimeNullableTotal,
    MedianTimeNullableTotal,
    PercentileContinuousTimeNullableTotal,
    PercentileDiscreteTimeNullableTotal,
    ModeTimeNullableTotal,
    LiteralTimeNullable,
    ParamTimeNullable
);
