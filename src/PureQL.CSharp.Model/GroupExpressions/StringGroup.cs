using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>string@group</c>.</summary>
public readonly union StringGroup(
    ConcatStringGroup,
    IfStringGroup,
    CoalesceStringGroup,
    MinStringGroup,
    MaxStringGroup,
    LiteralString,
    ParamString,
    KeyString
);
