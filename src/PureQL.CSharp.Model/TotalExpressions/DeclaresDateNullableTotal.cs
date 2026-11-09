using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.date.nullable@total</c>.</summary>
public readonly union DeclaresDateNullableTotal(
    DateAddDaysDateNullableTotal,
    IfDateNullableTotal,
    CoalesceDateNullableTotal,
    AverageDateNullableTotal,
    MinDateNullableTotal,
    MaxDateNullableTotal,
    LiteralDateNullable,
    ParamDateNullable
);
