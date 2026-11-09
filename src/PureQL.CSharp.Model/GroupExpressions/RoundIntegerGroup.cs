using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.integer@group</c>.</summary>
public sealed record RoundIntegerGroup : IOperator
{
    public RoundIntegerGroup(DecimalGroup operand)
    {
        Operand = operand;
    }

    public DecimalGroup Operand { get; }

    public IType Type => new TypeInteger();
}
