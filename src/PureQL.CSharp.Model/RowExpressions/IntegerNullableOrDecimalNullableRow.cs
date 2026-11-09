using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public readonly union IntegerNullableOrDecimalNullableRow(
    AddIntegerNullableRow,
    SubtractIntegerNullableRow,
    MultiplyIntegerNullableRow,
    IntegerDivideIntegerNullableRow,
    ModuloIntegerNullableRow,
    FloorIntegerNullableRow,
    CeilingIntegerNullableRow,
    RoundIntegerNullableRow,
    DateDiffDaysIntegerNullableRow,
    IfIntegerNullableRow,
    CoalesceIntegerNullableRow,
    LiteralIntegerNullable,
    ParamIntegerNullable,
    FieldIntegerNullable,
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
