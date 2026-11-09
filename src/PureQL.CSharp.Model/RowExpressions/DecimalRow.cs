using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>decimal@row</c>.</summary>
public readonly union DecimalRow(
    AddIntegerRow,
    SubtractIntegerRow,
    MultiplyIntegerRow,
    IntegerDivideIntegerRow,
    ModuloIntegerRow,
    FloorIntegerRow,
    CeilingIntegerRow,
    RoundIntegerRow,
    DateDiffDaysIntegerRow,
    IfIntegerRow,
    CoalesceIntegerRow,
    LiteralInteger,
    ParamInteger,
    FieldInteger,
    AddDecimalRow,
    SubtractDecimalRow,
    MultiplyDecimalRow,
    DivideDecimalRow,
    RoundDecimalRow,
    TimeDiffSecondsDecimalRow,
    DatetimeDiffSecondsDecimalRow,
    IfDecimalRow,
    CoalesceDecimalRow,
    LiteralDecimal,
    ParamDecimal,
    FieldDecimal
);
