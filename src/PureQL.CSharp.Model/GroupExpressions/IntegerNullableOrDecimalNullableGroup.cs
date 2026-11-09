using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public readonly union IntegerNullableOrDecimalNullableGroup(
    AddIntegerNullableGroup,
    SubtractIntegerNullableGroup,
    MultiplyIntegerNullableGroup,
    IntegerDivideIntegerNullableGroup,
    ModuloIntegerNullableGroup,
    FloorIntegerNullableGroup,
    CeilingIntegerNullableGroup,
    RoundIntegerNullableGroup,
    DateDiffDaysIntegerNullableGroup,
    IfIntegerNullableGroup,
    CoalesceIntegerNullableGroup,
    MinIntegerNullableGroup,
    MaxIntegerNullableGroup,
    LiteralIntegerNullable,
    ParamIntegerNullable,
    KeyIntegerNullable,
    AddDecimalNullableGroup,
    SubtractDecimalNullableGroup,
    MultiplyDecimalNullableGroup,
    DivideDecimalNullableGroup,
    RoundDecimalNullableGroup,
    TimeDiffSecondsDecimalNullableGroup,
    DatetimeDiffSecondsDecimalNullableGroup,
    IfDecimalNullableGroup,
    CoalesceDecimalNullableGroup,
    AverageDecimalNullableGroup,
    MinDecimalNullableGroup,
    MaxDecimalNullableGroup,
    LiteralDecimalNullable,
    ParamDecimalNullable,
    KeyDecimalNullable
);
