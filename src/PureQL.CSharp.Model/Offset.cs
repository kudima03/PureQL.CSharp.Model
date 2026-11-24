using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>offset</c>.</summary>
public readonly union Offset(LiteralInteger, ParamInteger);
