using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>regexPattern</c>.</summary>
public readonly union RegexPattern(LiteralString, ParamString);
