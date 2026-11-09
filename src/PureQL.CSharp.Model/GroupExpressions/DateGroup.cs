using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>date@group</c>.</summary>
public readonly union DateGroup(
    DateAddDaysDateGroup,
    IfDateGroup,
    CoalesceDateGroup,
    AverageDateGroup,
    MinDateGroup,
    MaxDateGroup,
    LiteralDate,
    ParamDate,
    KeyDate
);
