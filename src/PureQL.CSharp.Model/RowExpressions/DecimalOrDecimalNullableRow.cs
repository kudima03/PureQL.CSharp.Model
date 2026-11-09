using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public readonly union DecimalOrDecimalNullableRow(
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
    FieldDecimal,
    AddDecimalNullableRow,
    SubtractDecimalNullableRow,
    MultiplyDecimalNullableRow,
    DivideDecimalNullableRow,
    RoundDecimalNullableRow,
    TimeDiffSecondsDecimalNullableRow,
    DatetimeDiffSecondsDecimalNullableRow,
    IfDecimalNullableRow,
    CoalesceDecimalNullableRow,
    LiteralDecimalNullable,
    ParamDecimalNullable,
    FieldDecimalNullable
);
