using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>date.nullable@group</c>.</summary>
public readonly union DateNullableGroup(
    DateAddDaysDateGroup,
    IfDateGroup,
    CoalesceDateGroup,
    AverageDateGroup,
    MinDateGroup,
    MaxDateGroup,
    LiteralDate,
    ParamDate,
    KeyDate,
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
