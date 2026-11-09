using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.datetime.nullable@total</c>.</summary>
public readonly union DeclaresDatetimeNullableTotal(
    DatetimeAddSecondsDatetimeNullableTotal,
    IfDatetimeNullableTotal,
    CoalesceDatetimeNullableTotal,
    AverageDatetimeNullableTotal,
    MinDatetimeNullableTotal,
    MaxDatetimeNullableTotal,
    LiteralDatetimeNullable,
    ParamDatetimeNullable
);
