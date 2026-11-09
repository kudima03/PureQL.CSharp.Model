using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.string.nullable@row</c>.</summary>
public readonly union DeclaresStringNullableRow(
    ConcatStringNullableRow,
    IfStringNullableRow,
    CoalesceStringNullableRow,
    LiteralStringNullable,
    ParamStringNullable,
    FieldStringNullable
);
