using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.boolean.nullable@projection</c>.</summary>
public readonly union DeclaresBooleanNullableProjection(
    IfBooleanNullableProjection,
    CoalesceBooleanNullableProjection,
    MinBooleanNullableProjection,
    MaxBooleanNullableProjection,
    LiteralBooleanNullable,
    ParamBooleanNullable,
    FieldBooleanNullable
);
