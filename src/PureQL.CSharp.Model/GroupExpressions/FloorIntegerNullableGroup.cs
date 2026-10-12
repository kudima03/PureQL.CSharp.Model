using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record FloorIntegerNullableGroup : IOperator
{
    public FloorIntegerNullableGroup(DecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public DecimalNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
