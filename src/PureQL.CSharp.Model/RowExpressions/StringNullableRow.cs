using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>string.nullable@row</c>.</summary>
public readonly union StringNullableRow(
    ConcatStringRow,
    IfStringRow,
    CoalesceStringRow,
    LiteralString,
    ParamString,
    FieldString,
    ConcatStringNullableRow,
    IfStringNullableRow,
    CoalesceStringNullableRow,
    LiteralStringNullable,
    ParamStringNullable,
    FieldStringNullable
);
