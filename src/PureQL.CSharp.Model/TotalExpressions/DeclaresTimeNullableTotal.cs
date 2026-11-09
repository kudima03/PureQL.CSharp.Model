using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.time.nullable@total</c>.</summary>
public readonly union DeclaresTimeNullableTotal(
    TimeAddSecondsTimeNullableTotal,
    IfTimeNullableTotal,
    CoalesceTimeNullableTotal,
    AverageTimeNullableTotal,
    MinTimeNullableTotal,
    MaxTimeNullableTotal,
    LiteralTimeNullable,
    ParamTimeNullable
);
