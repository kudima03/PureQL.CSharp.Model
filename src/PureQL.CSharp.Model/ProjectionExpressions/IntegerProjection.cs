using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>integer@projection</c>.</summary>
public readonly union IntegerProjection(
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
    FieldInteger
);
