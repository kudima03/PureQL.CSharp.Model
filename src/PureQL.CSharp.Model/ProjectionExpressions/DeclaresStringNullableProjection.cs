using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.string.nullable@projection</c>.</summary>
public readonly union DeclaresStringNullableProjection(
    ConcatStringNullableProjection,
    IfStringNullableProjection,
    CoalesceStringNullableProjection,
    MinStringNullableProjection,
    MaxStringNullableProjection,
    LiteralStringNullable,
    ParamStringNullable,
    FieldStringNullable
);
