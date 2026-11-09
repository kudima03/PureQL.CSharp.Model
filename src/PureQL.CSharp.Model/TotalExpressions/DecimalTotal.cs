using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>decimal@total</c>.</summary>
public readonly union DecimalTotal(
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
    AddDecimalTotal,
    SubtractDecimalTotal,
    MultiplyDecimalTotal,
    DivideDecimalTotal,
    RoundDecimalTotal,
    TimeDiffSecondsDecimalTotal,
    DatetimeDiffSecondsDecimalTotal,
    IfDecimalTotal,
    CoalesceDecimalTotal,
    SumDecimalTotal,
    LiteralDecimal,
    ParamDecimal
);
