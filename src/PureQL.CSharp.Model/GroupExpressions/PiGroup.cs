using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>pi@group</c>.</summary>
public sealed record PiGroup : IOperator
{
    public IType Type => new TypeDecimal();
}
