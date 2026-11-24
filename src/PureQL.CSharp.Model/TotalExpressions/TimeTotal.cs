using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>time@total</c>.</summary>
public readonly union TimeTotal(
    TimeAddSecondsTimeTotal,
    TimeFromPartsTimeTotal,
    StartOfHourTimeTotal,
    StartOfMinuteTimeTotal,
    StartOfSecondTimeTotal,
    AsTimeDatetimeTimeTotal,
    AsTimeStringTimeTotal,
    IfTimeTotal,
    CoalesceTimeTotal,
    GreatestTimeTotal,
    LeastTimeTotal,
    LiteralTime,
    ParamTime
);
