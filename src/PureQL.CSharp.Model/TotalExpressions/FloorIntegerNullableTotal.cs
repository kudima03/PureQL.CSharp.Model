using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>floor.integer.nullable@total</c>.</summary>
public sealed record FloorIntegerNullableTotal : IOperator
{
    public FloorIntegerNullableTotal(DeclaresDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
