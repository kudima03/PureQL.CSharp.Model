using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>ceiling.integer.nullable@group</c>.</summary>
public sealed record CeilingIntegerNullableGroup : IOperator
{
    public CeilingIntegerNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
