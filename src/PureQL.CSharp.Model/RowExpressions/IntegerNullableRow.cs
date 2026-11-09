using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>integer.nullable@row</c>.</summary>
public readonly union IntegerNullableRow(
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
    FieldIntegerNullable
);
