using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.integer.nullable@total</c>.</summary>
public readonly union DeclaresIntegerNullableTotal(
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
