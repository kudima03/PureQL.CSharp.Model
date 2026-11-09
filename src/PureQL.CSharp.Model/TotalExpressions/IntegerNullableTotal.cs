using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>integer.nullable@total</c>.</summary>
public readonly union IntegerNullableTotal(
    AddIntegerTotal,
    SubtractIntegerTotal,
    MultiplyIntegerTotal,
    IntegerDivideIntegerTotal,
    ModuloIntegerTotal,
    FloorIntegerTotal,
    CeilingIntegerTotal,
    RoundIntegerTotal,
    DateDiffDaysIntegerTotal,
    IfIntegerTotal,
    CoalesceIntegerTotal,
    CountTotal,
    SumIntegerTotal,
    LiteralInteger,
    ParamInteger,
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
    ParamIntegerNullable
);
