using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>floor.integer.nullable@group</c>.</summary>
public sealed record FloorIntegerNullableGroup : IOperator
{
    public FloorIntegerNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
