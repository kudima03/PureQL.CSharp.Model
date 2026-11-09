using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>date.nullable@projection</c>.</summary>
public readonly union DateNullableProjection(
    DateAddDaysDateProjection,
    IfDateProjection,
    CoalesceDateProjection,
    AverageDateProjection,
    MinDateProjection,
    MaxDateProjection,
    LiteralDate,
    ParamDate,
    FieldDate,
    DateAddDaysDateNullableProjection,
    IfDateNullableProjection,
    CoalesceDateNullableProjection,
    AverageDateNullableProjection,
    MinDateNullableProjection,
    MaxDateNullableProjection,
    LiteralDateNullable,
    ParamDateNullable,
    FieldDateNullable
);
