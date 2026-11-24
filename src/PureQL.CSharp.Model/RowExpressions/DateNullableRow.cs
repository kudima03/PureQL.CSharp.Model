using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>date.nullable@row</c>.</summary>
public readonly union DateNullableRow(
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
    FieldDate,
    DateAddDaysDateNullableRow,
    DateAddMonthsDateNullableRow,
    DateFromPartsDateNullableRow,
    StartOfYearDateNullableRow,
    StartOfQuarterDateNullableRow,
    StartOfMonthDateNullableRow,
    StartOfWeekDateNullableRow,
    AsDateDatetimeDateNullableRow,
    AsDateStringDateNullableRow,
    AsNullableDateNullableRow,
    TryAsDateRow,
    IfDateNullableRow,
    CoalesceDateNullableRow,
    NullIfEqualDateNullableRow,
    GreatestDateNullableRow,
    LeastDateNullableRow,
    LiteralDateNullable,
    ParamDateNullable,
    FieldDateNullable
);
