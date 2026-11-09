using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>time@group</c>.</summary>
public readonly union TimeGroup(
    TimeAddSecondsTimeGroup,
    IfTimeGroup,
    CoalesceTimeGroup,
    AverageTimeGroup,
    MinTimeGroup,
    MaxTimeGroup,
    LiteralTime,
    ParamTime,
    KeyTime
);
