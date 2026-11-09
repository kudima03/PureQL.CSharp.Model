using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>integer@row</c>.</summary>
public readonly union IntegerRow(
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
    FieldInteger
);
