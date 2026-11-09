using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.integer.nullable@group</c>.</summary>
public readonly union DeclaresIntegerNullableGroup(
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
    KeyIntegerNullable
);
