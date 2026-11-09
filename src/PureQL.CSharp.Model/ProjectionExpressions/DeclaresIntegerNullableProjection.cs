using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.integer.nullable@projection</c>.</summary>
public readonly union DeclaresIntegerNullableProjection(
    AddIntegerNullableProjection,
    SubtractIntegerNullableProjection,
    MultiplyIntegerNullableProjection,
    IntegerDivideIntegerNullableProjection,
    ModuloIntegerNullableProjection,
    FloorIntegerNullableProjection,
    CeilingIntegerNullableProjection,
    RoundIntegerNullableProjection,
    DateDiffDaysIntegerNullableProjection,
    IfIntegerNullableProjection,
    CoalesceIntegerNullableProjection,
    MinIntegerNullableProjection,
    MaxIntegerNullableProjection,
    LiteralIntegerNullable,
    ParamIntegerNullable,
    FieldIntegerNullable
);
