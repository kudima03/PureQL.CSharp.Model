using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>ceiling.integer@group</c>.</summary>
public sealed record CeilingIntegerGroup : IOperator
{
    public CeilingIntegerGroup(DeclaresDecimalGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalGroup Operand { get; }

    public IType Type => new TypeInteger();
}
