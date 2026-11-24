using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>time@projection</c>.</summary>
public readonly union TimeProjection(
    TimeAddSecondsTimeProjection,
    TimeFromPartsTimeProjection,
    StartOfHourTimeProjection,
    StartOfMinuteTimeProjection,
    StartOfSecondTimeProjection,
    AsTimeDatetimeTimeProjection,
    AsTimeStringTimeProjection,
    IfTimeProjection,
    CoalesceTimeProjection,
    GreatestTimeProjection,
    LeastTimeProjection,
    AverageTimeProjection,
    MinTimeProjection,
    MaxTimeProjection,
    FirstTimeProjection,
    LastTimeProjection,
    MedianTimeProjection,
    PercentileContinuousTimeProjection,
    PercentileDiscreteTimeProjection,
    ModeTimeProjection,
    PreviousTimeProjection,
    NextTimeProjection,
    LiteralTime,
    ParamTime,
    FieldTime
);
