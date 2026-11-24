using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.datetime.nullable@total</c>.</summary>
public readonly union DeclaresDatetimeNullableTotal(
    DatetimeAddSecondsDatetimeNullableTotal,
    DatetimeAddMonthsDatetimeNullableTotal,
    DatetimeFromPartsDatetimeNullableTotal,
    StartOfYearDatetimeNullableTotal,
    StartOfQuarterDatetimeNullableTotal,
    StartOfMonthDatetimeNullableTotal,
    StartOfWeekDatetimeNullableTotal,
    StartOfDayDatetimeNullableTotal,
    StartOfHourDatetimeNullableTotal,
    StartOfMinuteDatetimeNullableTotal,
    StartOfSecondDatetimeNullableTotal,
    AsDatetimeDateDatetimeNullableTotal,
    AsDatetimeStringDatetimeNullableTotal,
    AsNullableDatetimeNullableTotal,
    TryAsDatetimeTotal,
    IfDatetimeNullableTotal,
    CoalesceDatetimeNullableTotal,
    NullIfEqualDatetimeNullableTotal,
    GreatestDatetimeNullableTotal,
    LeastDatetimeNullableTotal,
    AverageDatetimeNullableTotal,
    MinDatetimeNullableTotal,
    MaxDatetimeNullableTotal,
    FirstDatetimeNullableTotal,
    LastDatetimeNullableTotal,
    MedianDatetimeNullableTotal,
    PercentileContinuousDatetimeNullableTotal,
    PercentileDiscreteDatetimeNullableTotal,
    ModeDatetimeNullableTotal,
    LiteralDatetimeNullable,
    ParamDatetimeNullable
);
