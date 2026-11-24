using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>date@total</c>.</summary>
public readonly union DateTotal(
    DateAddDaysDateTotal,
    DateAddMonthsDateTotal,
    DateFromPartsDateTotal,
    StartOfYearDateTotal,
    StartOfQuarterDateTotal,
    StartOfMonthDateTotal,
    StartOfWeekDateTotal,
    AsDateDatetimeDateTotal,
    AsDateStringDateTotal,
    IfDateTotal,
    CoalesceDateTotal,
    GreatestDateTotal,
    LeastDateTotal,
    LiteralDate,
    ParamDate
);
