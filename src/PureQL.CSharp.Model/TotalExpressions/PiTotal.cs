using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>pi@total</c>.</summary>
public sealed record PiTotal : IOperator
{
    public IType Type => new TypeDecimal();
}
