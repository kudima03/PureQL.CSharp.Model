using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.decimal@row</c>.</summary>
public readonly union DeclaresDecimalRow(
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
