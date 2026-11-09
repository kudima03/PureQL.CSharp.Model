using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetime@group</c>.</summary>
public readonly union DatetimeGroup(
    DatetimeAddSecondsDatetimeGroup,
    IfDatetimeGroup,
    CoalesceDatetimeGroup,
    AverageDatetimeGroup,
    MinDatetimeGroup,
    MaxDatetimeGroup,
    LiteralDatetime,
    ParamDatetime,
    KeyDatetime
);
