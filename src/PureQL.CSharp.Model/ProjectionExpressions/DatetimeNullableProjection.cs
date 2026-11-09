using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetime.nullable@projection</c>.</summary>
public readonly union DatetimeNullableProjection(
    DatetimeAddSecondsDatetimeProjection,
    IfDatetimeProjection,
    CoalesceDatetimeProjection,
    AverageDatetimeProjection,
    MinDatetimeProjection,
    MaxDatetimeProjection,
    LiteralDatetime,
    ParamDatetime,
    FieldDatetime,
    DatetimeAddSecondsDatetimeNullableProjection,
    IfDatetimeNullableProjection,
    CoalesceDatetimeNullableProjection,
    AverageDatetimeNullableProjection,
    MinDatetimeNullableProjection,
    MaxDatetimeNullableProjection,
    LiteralDatetimeNullable,
    ParamDatetimeNullable,
    FieldDatetimeNullable
);
