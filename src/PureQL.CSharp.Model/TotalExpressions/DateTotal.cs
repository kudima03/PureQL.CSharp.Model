using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>date@total</c>.</summary>
public readonly union DateTotal(
    DateAddDaysDateTotal,
    IfDateTotal,
    CoalesceDateTotal,
    LiteralDate,
    ParamDate
);
