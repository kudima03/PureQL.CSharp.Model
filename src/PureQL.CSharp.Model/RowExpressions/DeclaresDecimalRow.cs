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
    ModuloDecimalRow,
    RoundDecimalRow,
    TruncateDecimalRow,
    AbsDecimalRow,
    PowerDecimalRow,
    SqrtDecimalRow,
    ExpDecimalRow,
    LnDecimalRow,
    Log10DecimalRow,
    LogDecimalRow,
    SinDecimalRow,
    CosDecimalRow,
    TanDecimalRow,
    AsinDecimalRow,
    AcosDecimalRow,
    AtanDecimalRow,
    Atan2DecimalRow,
    PiRow,
    TimeDiffSecondsDecimalRow,
    DatetimeDiffSecondsDecimalRow,
    AsDecimalIntegerDecimalRow,
    AsDecimalStringDecimalRow,
    IfDecimalRow,
    CoalesceDecimalRow,
    GreatestDecimalRow,
    LeastDecimalRow,
    LiteralDecimal,
    ParamDecimal,
    FieldDecimal
);
