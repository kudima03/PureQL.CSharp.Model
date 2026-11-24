using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>date@row</c>.</summary>
public readonly union DateRow(
    DateAddDaysDateRow,
    DateAddMonthsDateRow,
    DateFromPartsDateRow,
    StartOfYearDateRow,
    StartOfQuarterDateRow,
    StartOfMonthDateRow,
    StartOfWeekDateRow,
    AsDateDatetimeDateRow,
    AsDateStringDateRow,
    IfDateRow,
    CoalesceDateRow,
    GreatestDateRow,
    LeastDateRow,
    LiteralDate,
    ParamDate,
    FieldDate
);
