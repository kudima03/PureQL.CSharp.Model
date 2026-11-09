using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetime.nullable@group</c>.</summary>
public readonly union DatetimeNullableGroup(
    DatetimeAddSecondsDatetimeGroup,
    IfDatetimeGroup,
    CoalesceDatetimeGroup,
    AverageDatetimeGroup,
    MinDatetimeGroup,
    MaxDatetimeGroup,
    LiteralDatetime,
    ParamDatetime,
    KeyDatetime,
    DatetimeAddSecondsDatetimeNullableGroup,
    IfDatetimeNullableGroup,
    CoalesceDatetimeNullableGroup,
    AverageDatetimeNullableGroup,
    MinDatetimeNullableGroup,
    MaxDatetimeNullableGroup,
    LiteralDatetimeNullable,
    ParamDatetimeNullable,
    KeyDatetimeNullable
);
