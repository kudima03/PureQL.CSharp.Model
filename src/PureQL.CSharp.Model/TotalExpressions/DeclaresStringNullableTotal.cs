using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.string.nullable@total</c>.</summary>
public readonly union DeclaresStringNullableTotal(
    ConcatStringNullableTotal,
    IfStringNullableTotal,
    CoalesceStringNullableTotal,
    MinStringNullableTotal,
    MaxStringNullableTotal,
    LiteralStringNullable,
    ParamStringNullable
);
