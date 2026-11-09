using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetime@total</c>.</summary>
public readonly union DatetimeTotal(
    DatetimeAddSecondsDatetimeTotal,
    IfDatetimeTotal,
    CoalesceDatetimeTotal,
    LiteralDatetime,
    ParamDatetime
);
