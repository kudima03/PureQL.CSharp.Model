using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.string.nullable@group</c>.</summary>
public readonly union DeclaresStringNullableGroup(
    ConcatStringNullableGroup,
    IfStringNullableGroup,
    CoalesceStringNullableGroup,
    MinStringNullableGroup,
    MaxStringNullableGroup,
    LiteralStringNullable,
    ParamStringNullable,
    KeyStringNullable
);
