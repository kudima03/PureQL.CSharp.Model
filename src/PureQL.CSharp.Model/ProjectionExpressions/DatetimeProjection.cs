using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetime@projection</c>.</summary>
public readonly union DatetimeProjection(
    DatetimeAddSecondsDatetimeProjection,
    IfDatetimeProjection,
    CoalesceDatetimeProjection,
    AverageDatetimeProjection,
    MinDatetimeProjection,
    MaxDatetimeProjection,
    LiteralDatetime,
    ParamDatetime,
    FieldDatetime
);
