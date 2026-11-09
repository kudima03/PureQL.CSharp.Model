using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.integer.nullable@row</c>.</summary>
public readonly union DeclaresIntegerNullableRow(
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
