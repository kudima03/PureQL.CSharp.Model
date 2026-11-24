using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>time@group</c>.</summary>
public readonly union TimeGroup(
    TimeAddSecondsTimeGroup,
    TimeFromPartsTimeGroup,
    StartOfHourTimeGroup,
    StartOfMinuteTimeGroup,
    StartOfSecondTimeGroup,
    AsTimeDatetimeTimeGroup,
    AsTimeStringTimeGroup,
    IfTimeGroup,
    CoalesceTimeGroup,
    GreatestTimeGroup,
    LeastTimeGroup,
    AverageTimeGroup,
    MinTimeGroup,
    MaxTimeGroup,
    FirstTimeGroup,
    LastTimeGroup,
    MedianTimeGroup,
    PercentileContinuousTimeGroup,
    PercentileDiscreteTimeGroup,
    ModeTimeGroup,
    LiteralTime,
    ParamTime,
    KeyTime
);
