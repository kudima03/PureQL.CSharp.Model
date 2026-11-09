using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>decimal@projection</c>.</summary>
public readonly union DecimalProjection(
    AddIntegerProjection,
    SubtractIntegerProjection,
    MultiplyIntegerProjection,
    IntegerDivideIntegerProjection,
    ModuloIntegerProjection,
    FloorIntegerProjection,
    CeilingIntegerProjection,
    RoundIntegerProjection,
    DateDiffDaysIntegerProjection,
    IfIntegerProjection,
    CoalesceIntegerProjection,
    CountProjection,
    SumIntegerProjection,
    MinIntegerProjection,
    MaxIntegerProjection,
    LiteralInteger,
    ParamInteger,
    FieldInteger,
    AddDecimalProjection,
    SubtractDecimalProjection,
    MultiplyDecimalProjection,
    DivideDecimalProjection,
    RoundDecimalProjection,
    TimeDiffSecondsDecimalProjection,
    DatetimeDiffSecondsDecimalProjection,
    IfDecimalProjection,
    CoalesceDecimalProjection,
    SumDecimalProjection,
    AverageDecimalProjection,
    MinDecimalProjection,
    MaxDecimalProjection,
    LiteralDecimal,
    ParamDecimal,
    FieldDecimal
);
