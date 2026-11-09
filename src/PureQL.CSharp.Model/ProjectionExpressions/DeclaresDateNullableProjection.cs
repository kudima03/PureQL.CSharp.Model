using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.date.nullable@projection</c>.</summary>
public readonly union DeclaresDateNullableProjection(
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
