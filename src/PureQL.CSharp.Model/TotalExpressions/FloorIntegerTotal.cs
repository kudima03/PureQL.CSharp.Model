using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>floor.integer@total</c>.</summary>
public sealed record FloorIntegerTotal : IOperator
{
    public FloorIntegerTotal(DeclaresDecimalTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalTotal Operand { get; }

    public IType Type => new TypeInteger();
}
