using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.date.nullable@total</c>.</summary>
public readonly union DeclaresDateNullableTotal(
    DateAddDaysDateNullableTotal,
    DateAddMonthsDateNullableTotal,
    DateFromPartsDateNullableTotal,
    StartOfYearDateNullableTotal,
    StartOfQuarterDateNullableTotal,
    StartOfMonthDateNullableTotal,
    StartOfWeekDateNullableTotal,
    AsDateDatetimeDateNullableTotal,
    AsDateStringDateNullableTotal,
    AsNullableDateNullableTotal,
    TryAsDateTotal,
    IfDateNullableTotal,
    CoalesceDateNullableTotal,
    NullIfEqualDateNullableTotal,
    GreatestDateNullableTotal,
    LeastDateNullableTotal,
    AverageDateNullableTotal,
    MinDateNullableTotal,
    MaxDateNullableTotal,
    FirstDateNullableTotal,
    LastDateNullableTotal,
    MedianDateNullableTotal,
    PercentileContinuousDateNullableTotal,
    PercentileDiscreteDateNullableTotal,
    ModeDateNullableTotal,
    LiteralDateNullable,
    ParamDateNullable
);
