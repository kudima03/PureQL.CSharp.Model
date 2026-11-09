using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>time.nullable@total</c>.</summary>
public readonly union TimeNullableTotal(
    TimeAddSecondsTimeTotal,
    IfTimeTotal,
    CoalesceTimeTotal,
    LiteralTime,
    ParamTime,
    TimeAddSecondsTimeNullableTotal,
    IfTimeNullableTotal,
    CoalesceTimeNullableTotal,
    AverageTimeNullableTotal,
    MinTimeNullableTotal,
    MaxTimeNullableTotal,
    LiteralTimeNullable,
    ParamTimeNullable
);
