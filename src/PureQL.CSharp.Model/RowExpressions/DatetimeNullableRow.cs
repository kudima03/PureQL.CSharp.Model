using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetime.nullable@row</c>.</summary>
public readonly union DatetimeNullableRow(
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
    FieldDatetime,
    DatetimeAddSecondsDatetimeNullableRow,
    DatetimeAddMonthsDatetimeNullableRow,
    DatetimeFromPartsDatetimeNullableRow,
    StartOfYearDatetimeNullableRow,
    StartOfQuarterDatetimeNullableRow,
    StartOfMonthDatetimeNullableRow,
    StartOfWeekDatetimeNullableRow,
    StartOfDayDatetimeNullableRow,
    StartOfHourDatetimeNullableRow,
    StartOfMinuteDatetimeNullableRow,
    StartOfSecondDatetimeNullableRow,
    AsDatetimeDateDatetimeNullableRow,
    AsDatetimeStringDatetimeNullableRow,
    AsNullableDatetimeNullableRow,
    TryAsDatetimeRow,
    IfDatetimeNullableRow,
    CoalesceDatetimeNullableRow,
    NullIfEqualDatetimeNullableRow,
    GreatestDatetimeNullableRow,
    LeastDatetimeNullableRow,
    LiteralDatetimeNullable,
    ParamDatetimeNullable,
    FieldDatetimeNullable
);
