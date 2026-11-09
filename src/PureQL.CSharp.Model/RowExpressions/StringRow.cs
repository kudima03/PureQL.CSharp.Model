using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>string@row</c>.</summary>
public readonly union StringRow(
    ConcatStringRow,
    IfStringRow,
    CoalesceStringRow,
    LiteralString,
    ParamString,
    FieldString
);
