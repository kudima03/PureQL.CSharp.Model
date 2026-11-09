using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>integer@group</c>.</summary>
public readonly union IntegerGroup(
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
    KeyInteger
);
