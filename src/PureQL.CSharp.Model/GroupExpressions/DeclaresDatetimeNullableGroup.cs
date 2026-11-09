using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.datetime.nullable@group</c>.</summary>
public readonly union DeclaresDatetimeNullableGroup(
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
