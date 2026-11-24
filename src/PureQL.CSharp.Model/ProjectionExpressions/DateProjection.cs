using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>date@projection</c>.</summary>
public readonly union DateProjection(
    DateAddDaysDateProjection,
    DateAddMonthsDateProjection,
    DateFromPartsDateProjection,
    StartOfYearDateProjection,
    StartOfQuarterDateProjection,
    StartOfMonthDateProjection,
    StartOfWeekDateProjection,
    AsDateDatetimeDateProjection,
    AsDateStringDateProjection,
    IfDateProjection,
    CoalesceDateProjection,
    GreatestDateProjection,
    LeastDateProjection,
    AverageDateProjection,
    MinDateProjection,
    MaxDateProjection,
    FirstDateProjection,
    LastDateProjection,
    MedianDateProjection,
    PercentileContinuousDateProjection,
    PercentileDiscreteDateProjection,
    ModeDateProjection,
    PreviousDateProjection,
    NextDateProjection,
    LiteralDate,
    ParamDate,
    FieldDate
);
