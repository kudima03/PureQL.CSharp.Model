using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.time.nullable@group</c>.</summary>
public readonly union DeclaresTimeNullableGroup(
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
