using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>string.nullable@group</c>.</summary>
public readonly union StringNullableGroup(
    ConcatStringGroup,
    IfStringGroup,
    CoalesceStringGroup,
    MinStringGroup,
    MaxStringGroup,
    LiteralString,
    ParamString,
    KeyString,
    ConcatStringNullableGroup,
    IfStringNullableGroup,
    CoalesceStringNullableGroup,
    MinStringNullableGroup,
    MaxStringNullableGroup,
    LiteralStringNullable,
    ParamStringNullable,
    KeyStringNullable
);
