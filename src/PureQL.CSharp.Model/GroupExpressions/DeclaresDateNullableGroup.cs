using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.date.nullable@group</c>.</summary>
public readonly union DeclaresDateNullableGroup(
    DateAddDaysDateNullableGroup,
    IfDateNullableGroup,
    CoalesceDateNullableGroup,
    AverageDateNullableGroup,
    MinDateNullableGroup,
    MaxDateNullableGroup,
    LiteralDateNullable,
    ParamDateNullable,
    KeyDateNullable
);
