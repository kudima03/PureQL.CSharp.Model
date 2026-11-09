using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>date.nullable@total</c>.</summary>
public readonly union DateNullableTotal(
    DateAddDaysDateTotal,
    IfDateTotal,
    CoalesceDateTotal,
    LiteralDate,
    ParamDate,
    DateAddDaysDateNullableTotal,
    IfDateNullableTotal,
    CoalesceDateNullableTotal,
    AverageDateNullableTotal,
    MinDateNullableTotal,
    MaxDateNullableTotal,
    LiteralDateNullable,
    ParamDateNullable
);
