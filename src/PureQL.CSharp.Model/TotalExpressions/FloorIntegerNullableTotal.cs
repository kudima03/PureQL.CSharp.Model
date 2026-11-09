using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>floor.integer.nullable@total</c>.</summary>
public sealed record FloorIntegerNullableTotal : IOperator
{
    public FloorIntegerNullableTotal(IntegerNullableOrDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
