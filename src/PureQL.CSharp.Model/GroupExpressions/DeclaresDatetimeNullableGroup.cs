using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.datetime.nullable@group</c>.</summary>
public readonly union DeclaresDatetimeNullableGroup(
    DatetimeAddSecondsDatetimeNullableGroup,
    DatetimeAddMonthsDatetimeNullableGroup,
    DatetimeFromPartsDatetimeNullableGroup,
    StartOfYearDatetimeNullableGroup,
    StartOfQuarterDatetimeNullableGroup,
    StartOfMonthDatetimeNullableGroup,
    StartOfWeekDatetimeNullableGroup,
    StartOfDayDatetimeNullableGroup,
    StartOfHourDatetimeNullableGroup,
    StartOfMinuteDatetimeNullableGroup,
    StartOfSecondDatetimeNullableGroup,
    AsDatetimeDateDatetimeNullableGroup,
    AsDatetimeStringDatetimeNullableGroup,
    AsNullableDatetimeNullableGroup,
    TryAsDatetimeGroup,
    IfDatetimeNullableGroup,
    CoalesceDatetimeNullableGroup,
    NullIfEqualDatetimeNullableGroup,
    GreatestDatetimeNullableGroup,
    LeastDatetimeNullableGroup,
    AverageDatetimeNullableGroup,
    MinDatetimeNullableGroup,
    MaxDatetimeNullableGroup,
    FirstDatetimeNullableGroup,
    LastDatetimeNullableGroup,
    MedianDatetimeNullableGroup,
    PercentileContinuousDatetimeNullableGroup,
    PercentileDiscreteDatetimeNullableGroup,
    ModeDatetimeNullableGroup,
    LiteralDatetimeNullable,
    ParamDatetimeNullable,
    KeyDatetimeNullable
);
