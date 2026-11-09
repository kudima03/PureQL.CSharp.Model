using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public readonly union IntegerNullableOrDecimalNullableTotal(
    AddIntegerNullableTotal,
    SubtractIntegerNullableTotal,
    MultiplyIntegerNullableTotal,
    IntegerDivideIntegerNullableTotal,
    ModuloIntegerNullableTotal,
    FloorIntegerNullableTotal,
    CeilingIntegerNullableTotal,
    RoundIntegerNullableTotal,
    DateDiffDaysIntegerNullableTotal,
    IfIntegerNullableTotal,
    CoalesceIntegerNullableTotal,
    MinIntegerNullableTotal,
    MaxIntegerNullableTotal,
    LiteralIntegerNullable,
    ParamIntegerNullable,
    AddDecimalNullableTotal,
    SubtractDecimalNullableTotal,
    MultiplyDecimalNullableTotal,
    DivideDecimalNullableTotal,
    RoundDecimalNullableTotal,
    TimeDiffSecondsDecimalNullableTotal,
    DatetimeDiffSecondsDecimalNullableTotal,
    IfDecimalNullableTotal,
    CoalesceDecimalNullableTotal,
    AverageDecimalNullableTotal,
    MinDecimalNullableTotal,
    MaxDecimalNullableTotal,
    LiteralDecimalNullable,
    ParamDecimalNullable
);
