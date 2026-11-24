using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.date.nullable@projection</c>.</summary>
public readonly union DeclaresDateNullableProjection(
    DateAddDaysDateNullableProjection,
    DateAddMonthsDateNullableProjection,
    DateFromPartsDateNullableProjection,
    StartOfYearDateNullableProjection,
    StartOfQuarterDateNullableProjection,
    StartOfMonthDateNullableProjection,
    StartOfWeekDateNullableProjection,
    AsDateDatetimeDateNullableProjection,
    AsDateStringDateNullableProjection,
    AsNullableDateNullableProjection,
    TryAsDateProjection,
    IfDateNullableProjection,
    CoalesceDateNullableProjection,
    NullIfEqualDateNullableProjection,
    GreatestDateNullableProjection,
    LeastDateNullableProjection,
    AverageDateNullableProjection,
    MinDateNullableProjection,
    MaxDateNullableProjection,
    FirstDateNullableProjection,
    LastDateNullableProjection,
    MedianDateNullableProjection,
    PercentileContinuousDateNullableProjection,
    PercentileDiscreteDateNullableProjection,
    ModeDateNullableProjection,
    PreviousDateNullableProjection,
    NextDateNullableProjection,
    LiteralDateNullable,
    ParamDateNullable,
    FieldDateNullable
);
