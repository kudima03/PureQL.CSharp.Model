using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.integer.nullable@group</c>.</summary>
public sealed record RoundIntegerNullableGroup : IOperator
{
    public RoundIntegerNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
