using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>decimal@group</c>.</summary>
public readonly union DecimalGroup(
    AddIntegerGroup,
    SubtractIntegerGroup,
    MultiplyIntegerGroup,
    IntegerDivideIntegerGroup,
    ModuloIntegerGroup,
    FloorIntegerGroup,
    CeilingIntegerGroup,
    RoundIntegerGroup,
    DateDiffDaysIntegerGroup,
    IfIntegerGroup,
    CoalesceIntegerGroup,
    CountGroup,
    SumIntegerGroup,
    MinIntegerGroup,
    MaxIntegerGroup,
    LiteralInteger,
    ParamInteger,
    KeyInteger,
    AddDecimalGroup,
    SubtractDecimalGroup,
    MultiplyDecimalGroup,
    DivideDecimalGroup,
    RoundDecimalGroup,
    TimeDiffSecondsDecimalGroup,
    DatetimeDiffSecondsDecimalGroup,
    IfDecimalGroup,
    CoalesceDecimalGroup,
    SumDecimalGroup,
    AverageDecimalGroup,
    MinDecimalGroup,
    MaxDecimalGroup,
    LiteralDecimal,
    ParamDecimal,
    KeyDecimal
);
