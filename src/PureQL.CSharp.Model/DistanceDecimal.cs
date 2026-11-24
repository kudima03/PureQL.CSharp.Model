using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>distance.decimal</c>.</summary>
public readonly union DistanceDecimal(
    All,
    long,
    ParamInteger,
    LiteralDecimal,
    ParamDecimal
);
