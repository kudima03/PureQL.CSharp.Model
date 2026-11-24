using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>floor.integer@group</c>.</summary>
public sealed record FloorIntegerGroup : IOperator
{
    public FloorIntegerGroup(DeclaresDecimalGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalGroup Operand { get; }

    public IType Type => new TypeInteger();
}
