using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>time@projection</c>.</summary>
public readonly union TimeProjection(
    TimeAddSecondsTimeProjection,
    IfTimeProjection,
    CoalesceTimeProjection,
    AverageTimeProjection,
    MinTimeProjection,
    MaxTimeProjection,
    LiteralTime,
    ParamTime,
    FieldTime
);
