using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public readonly union IntegerNullableOrDecimalNullableProjection(
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
    FieldIntegerNullable,
    AddDecimalNullableProjection,
    SubtractDecimalNullableProjection,
    MultiplyDecimalNullableProjection,
    DivideDecimalNullableProjection,
    RoundDecimalNullableProjection,
    TimeDiffSecondsDecimalNullableProjection,
    DatetimeDiffSecondsDecimalNullableProjection,
    IfDecimalNullableProjection,
    CoalesceDecimalNullableProjection,
    AverageDecimalNullableProjection,
    MinDecimalNullableProjection,
    MaxDecimalNullableProjection,
    LiteralDecimalNullable,
    ParamDecimalNullable,
    FieldDecimalNullable
);
