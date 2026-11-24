using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetime@projection</c>.</summary>
public readonly union DatetimeProjection(
    DatetimeAddSecondsDatetimeProjection,
    DatetimeAddMonthsDatetimeProjection,
    DatetimeFromPartsDatetimeProjection,
    StartOfYearDatetimeProjection,
    StartOfQuarterDatetimeProjection,
    StartOfMonthDatetimeProjection,
    StartOfWeekDatetimeProjection,
    StartOfDayDatetimeProjection,
    StartOfHourDatetimeProjection,
    StartOfMinuteDatetimeProjection,
    StartOfSecondDatetimeProjection,
    AsDatetimeDateDatetimeProjection,
    AsDatetimeStringDatetimeProjection,
    IfDatetimeProjection,
    CoalesceDatetimeProjection,
    GreatestDatetimeProjection,
    LeastDatetimeProjection,
    AverageDatetimeProjection,
    MinDatetimeProjection,
    MaxDatetimeProjection,
    FirstDatetimeProjection,
    LastDatetimeProjection,
    MedianDatetimeProjection,
    PercentileContinuousDatetimeProjection,
    PercentileDiscreteDatetimeProjection,
    ModeDatetimeProjection,
    PreviousDatetimeProjection,
    NextDatetimeProjection,
    LiteralDatetime,
    ParamDatetime,
    FieldDatetime
);
