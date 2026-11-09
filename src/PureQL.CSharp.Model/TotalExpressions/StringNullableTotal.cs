using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>string.nullable@total</c>.</summary>
public readonly union StringNullableTotal(
    ConcatStringTotal,
    IfStringTotal,
    CoalesceStringTotal,
    LiteralString,
    ParamString,
    ConcatStringNullableTotal,
    IfStringNullableTotal,
    CoalesceStringNullableTotal,
    MinStringNullableTotal,
    MaxStringNullableTotal,
    LiteralStringNullable,
    ParamStringNullable
);
