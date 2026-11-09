using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>string@total</c>.</summary>
public readonly union StringTotal(
    ConcatStringTotal,
    IfStringTotal,
    CoalesceStringTotal,
    LiteralString,
    ParamString
);
