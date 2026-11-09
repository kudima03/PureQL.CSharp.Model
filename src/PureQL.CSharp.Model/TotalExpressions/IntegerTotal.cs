using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>integer@total</c>.</summary>
public readonly union IntegerTotal(
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
    ParamInteger
);
