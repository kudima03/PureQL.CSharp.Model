using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>floor.integer@row</c>.</summary>
public sealed record FloorIntegerRow : IOperator
{
    public FloorIntegerRow(DeclaresDecimalRow operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalRow Operand { get; }

    public IType Type => new TypeInteger();
}
