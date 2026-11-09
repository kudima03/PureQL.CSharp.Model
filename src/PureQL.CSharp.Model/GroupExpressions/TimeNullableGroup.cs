using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>time.nullable@group</c>.</summary>
public readonly union TimeNullableGroup(
    TimeAddSecondsTimeGroup,
    IfTimeGroup,
    CoalesceTimeGroup,
    AverageTimeGroup,
    MinTimeGroup,
    MaxTimeGroup,
    LiteralTime,
    ParamTime,
    KeyTime,
    TimeAddSecondsTimeNullableGroup,
    IfTimeNullableGroup,
    CoalesceTimeNullableGroup,
    AverageTimeNullableGroup,
    MinTimeNullableGroup,
    MaxTimeNullableGroup,
    LiteralTimeNullable,
    ParamTimeNullable,
    KeyTimeNullable
);
