using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.decimal.nullable@row</c>.</summary>
public readonly union DeclaresDecimalNullableRow(
    AddDecimalNullableRow,
    SubtractDecimalNullableRow,
    MultiplyDecimalNullableRow,
    DivideDecimalNullableRow,
    ModuloDecimalNullableRow,
    RoundDecimalNullableRow,
    TruncateDecimalNullableRow,
    AbsDecimalNullableRow,
    PowerDecimalNullableRow,
    SqrtDecimalNullableRow,
    ExpDecimalNullableRow,
    LnDecimalNullableRow,
    Log10DecimalNullableRow,
    LogDecimalNullableRow,
    SinDecimalNullableRow,
    CosDecimalNullableRow,
    TanDecimalNullableRow,
    AsinDecimalNullableRow,
    AcosDecimalNullableRow,
    AtanDecimalNullableRow,
    Atan2DecimalNullableRow,
    TimeDiffSecondsDecimalNullableRow,
    DatetimeDiffSecondsDecimalNullableRow,
    AsDecimalIntegerDecimalNullableRow,
    AsDecimalStringDecimalNullableRow,
    AsNullableDecimalNullableRow,
    TryAsDecimalRow,
    IfDecimalNullableRow,
    CoalesceDecimalNullableRow,
    NullIfEqualDecimalNullableRow,
    GreatestDecimalNullableRow,
    LeastDecimalNullableRow,
    LiteralDecimalNullable,
    ParamDecimalNullable,
    FieldDecimalNullable
);
