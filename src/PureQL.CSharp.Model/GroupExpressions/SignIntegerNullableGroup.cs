using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>sign.integer.nullable@group</c>.</summary>
public sealed record SignIntegerNullableGroup : IOperator
{
    public SignIntegerNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
