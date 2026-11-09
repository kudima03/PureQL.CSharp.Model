using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>date@projection</c>.</summary>
public readonly union DateProjection(
    DateAddDaysDateProjection,
    IfDateProjection,
    CoalesceDateProjection,
    AverageDateProjection,
    MinDateProjection,
    MaxDateProjection,
    LiteralDate,
    ParamDate,
    FieldDate
);
