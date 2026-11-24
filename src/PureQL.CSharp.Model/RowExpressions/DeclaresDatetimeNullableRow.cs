using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.datetime.nullable@row</c>.</summary>
public readonly union DeclaresDatetimeNullableRow(
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
