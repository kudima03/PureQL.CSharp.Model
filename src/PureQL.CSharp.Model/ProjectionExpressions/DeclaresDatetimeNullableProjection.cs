using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.datetime.nullable@projection</c>.</summary>
public readonly union DeclaresDatetimeNullableProjection(
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
