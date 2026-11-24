using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetime@row</c>.</summary>
public readonly union DatetimeRow(
    DatetimeAddSecondsDatetimeRow,
    DatetimeAddMonthsDatetimeRow,
    DatetimeFromPartsDatetimeRow,
    StartOfYearDatetimeRow,
    StartOfQuarterDatetimeRow,
    StartOfMonthDatetimeRow,
    StartOfWeekDatetimeRow,
    StartOfDayDatetimeRow,
    StartOfHourDatetimeRow,
    StartOfMinuteDatetimeRow,
    StartOfSecondDatetimeRow,
    AsDatetimeDateDatetimeRow,
    AsDatetimeStringDatetimeRow,
    IfDatetimeRow,
    CoalesceDatetimeRow,
    GreatestDatetimeRow,
    LeastDatetimeRow,
    LiteralDatetime,
    ParamDatetime,
    FieldDatetime
);
