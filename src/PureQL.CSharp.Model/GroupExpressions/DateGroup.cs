using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>date@group</c>.</summary>
public readonly union DateGroup(
    DateAddDaysDateGroup,
    DateAddMonthsDateGroup,
    DateFromPartsDateGroup,
    StartOfYearDateGroup,
    StartOfQuarterDateGroup,
    StartOfMonthDateGroup,
    StartOfWeekDateGroup,
    AsDateDatetimeDateGroup,
    AsDateStringDateGroup,
    IfDateGroup,
    CoalesceDateGroup,
    GreatestDateGroup,
    LeastDateGroup,
    AverageDateGroup,
    MinDateGroup,
    MaxDateGroup,
    FirstDateGroup,
    LastDateGroup,
    MedianDateGroup,
    PercentileContinuousDateGroup,
    PercentileDiscreteDateGroup,
    ModeDateGroup,
    LiteralDate,
    ParamDate,
    KeyDate
);
