using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>string.nullable@projection</c>.</summary>
public readonly union StringNullableProjection(
    ConcatStringProjection,
    IfStringProjection,
    CoalesceStringProjection,
    MinStringProjection,
    MaxStringProjection,
    LiteralString,
    ParamString,
    FieldString,
    ConcatStringNullableProjection,
    IfStringNullableProjection,
    CoalesceStringNullableProjection,
    MinStringNullableProjection,
    MaxStringNullableProjection,
    LiteralStringNullable,
    ParamStringNullable,
    FieldStringNullable
);
