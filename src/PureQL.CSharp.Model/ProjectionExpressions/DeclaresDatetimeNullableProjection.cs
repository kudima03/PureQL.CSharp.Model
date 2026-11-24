using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.datetime.nullable@projection</c>.</summary>
public readonly union DeclaresDatetimeNullableProjection(
    DatetimeAddSecondsDatetimeNullableProjection,
    DatetimeAddMonthsDatetimeNullableProjection,
    DatetimeFromPartsDatetimeNullableProjection,
    StartOfYearDatetimeNullableProjection,
    StartOfQuarterDatetimeNullableProjection,
    StartOfMonthDatetimeNullableProjection,
    StartOfWeekDatetimeNullableProjection,
    StartOfDayDatetimeNullableProjection,
    StartOfHourDatetimeNullableProjection,
    StartOfMinuteDatetimeNullableProjection,
    StartOfSecondDatetimeNullableProjection,
    AsDatetimeDateDatetimeNullableProjection,
    AsDatetimeStringDatetimeNullableProjection,
    AsNullableDatetimeNullableProjection,
    TryAsDatetimeProjection,
    IfDatetimeNullableProjection,
    CoalesceDatetimeNullableProjection,
    NullIfEqualDatetimeNullableProjection,
    GreatestDatetimeNullableProjection,
    LeastDatetimeNullableProjection,
    AverageDatetimeNullableProjection,
    MinDatetimeNullableProjection,
    MaxDatetimeNullableProjection,
    FirstDatetimeNullableProjection,
    LastDatetimeNullableProjection,
    MedianDatetimeNullableProjection,
    PercentileContinuousDatetimeNullableProjection,
    PercentileDiscreteDatetimeNullableProjection,
    ModeDatetimeNullableProjection,
    PreviousDatetimeNullableProjection,
    NextDatetimeNullableProjection,
    LiteralDatetimeNullable,
    ParamDatetimeNullable,
    FieldDatetimeNullable
);
