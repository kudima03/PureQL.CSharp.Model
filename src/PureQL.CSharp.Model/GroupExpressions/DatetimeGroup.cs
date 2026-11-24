using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetime@group</c>.</summary>
public readonly union DatetimeGroup(
    DatetimeAddSecondsDatetimeGroup,
    DatetimeAddMonthsDatetimeGroup,
    DatetimeFromPartsDatetimeGroup,
    StartOfYearDatetimeGroup,
    StartOfQuarterDatetimeGroup,
    StartOfMonthDatetimeGroup,
    StartOfWeekDatetimeGroup,
    StartOfDayDatetimeGroup,
    StartOfHourDatetimeGroup,
    StartOfMinuteDatetimeGroup,
    StartOfSecondDatetimeGroup,
    AsDatetimeDateDatetimeGroup,
    AsDatetimeStringDatetimeGroup,
    IfDatetimeGroup,
    CoalesceDatetimeGroup,
    GreatestDatetimeGroup,
    LeastDatetimeGroup,
    AverageDatetimeGroup,
    MinDatetimeGroup,
    MaxDatetimeGroup,
    FirstDatetimeGroup,
    LastDatetimeGroup,
    MedianDatetimeGroup,
    PercentileContinuousDatetimeGroup,
    PercentileDiscreteDatetimeGroup,
    ModeDatetimeGroup,
    LiteralDatetime,
    ParamDatetime,
    KeyDatetime
);
