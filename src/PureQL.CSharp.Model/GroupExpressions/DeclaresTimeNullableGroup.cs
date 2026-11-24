using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.time.nullable@group</c>.</summary>
public readonly union DeclaresTimeNullableGroup(
    TimeAddSecondsTimeNullableGroup,
    TimeFromPartsTimeNullableGroup,
    StartOfHourTimeNullableGroup,
    StartOfMinuteTimeNullableGroup,
    StartOfSecondTimeNullableGroup,
    AsTimeDatetimeTimeNullableGroup,
    AsTimeStringTimeNullableGroup,
    AsNullableTimeNullableGroup,
    TryAsTimeGroup,
    IfTimeNullableGroup,
    CoalesceTimeNullableGroup,
    NullIfEqualTimeNullableGroup,
    GreatestTimeNullableGroup,
    LeastTimeNullableGroup,
    AverageTimeNullableGroup,
    MinTimeNullableGroup,
    MaxTimeNullableGroup,
    FirstTimeNullableGroup,
    LastTimeNullableGroup,
    MedianTimeNullableGroup,
    PercentileContinuousTimeNullableGroup,
    PercentileDiscreteTimeNullableGroup,
    ModeTimeNullableGroup,
    LiteralTimeNullable,
    ParamTimeNullable,
    KeyTimeNullable
);
