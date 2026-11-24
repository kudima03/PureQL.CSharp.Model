using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.decimal@total</c>.</summary>
public readonly union DeclaresDecimalTotal(
    AddDecimalTotal,
    SubtractDecimalTotal,
    MultiplyDecimalTotal,
    DivideDecimalTotal,
    ModuloDecimalTotal,
    RoundDecimalTotal,
    TruncateDecimalTotal,
    AbsDecimalTotal,
    PowerDecimalTotal,
    SqrtDecimalTotal,
    ExpDecimalTotal,
    LnDecimalTotal,
    Log10DecimalTotal,
    LogDecimalTotal,
    SinDecimalTotal,
    CosDecimalTotal,
    TanDecimalTotal,
    AsinDecimalTotal,
    AcosDecimalTotal,
    AtanDecimalTotal,
    Atan2DecimalTotal,
    PiTotal,
    TimeDiffSecondsDecimalTotal,
    DatetimeDiffSecondsDecimalTotal,
    AsDecimalIntegerDecimalTotal,
    AsDecimalStringDecimalTotal,
    IfDecimalTotal,
    CoalesceDecimalTotal,
    GreatestDecimalTotal,
    LeastDecimalTotal,
    SumDecimalTotal,
    LiteralDecimal,
    ParamDecimal
);
