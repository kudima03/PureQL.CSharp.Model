using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>fraction</c>.</summary>
public readonly union Fraction(LiteralDecimal, ParamDecimal);
