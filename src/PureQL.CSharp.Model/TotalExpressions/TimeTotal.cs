using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>time@total</c>.</summary>
public readonly union TimeTotal(
    TimeAddSecondsTimeTotal,
    IfTimeTotal,
    CoalesceTimeTotal,
    LiteralTime,
    ParamTime
);
