using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>datetime.nullable@total</c>.</summary>
public readonly union DatetimeNullableTotal(
    DatetimeAddSecondsDatetimeTotal,
    IfDatetimeTotal,
    CoalesceDatetimeTotal,
    LiteralDatetime,
    ParamDatetime,
    DatetimeAddSecondsDatetimeNullableTotal,
    IfDatetimeNullableTotal,
    CoalesceDatetimeNullableTotal,
    AverageDatetimeNullableTotal,
    MinDatetimeNullableTotal,
    MaxDatetimeNullableTotal,
    LiteralDatetimeNullable,
    ParamDatetimeNullable
);
