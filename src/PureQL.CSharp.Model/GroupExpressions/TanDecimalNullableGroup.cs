using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tan.decimal.nullable@group</c>.</summary>
public sealed record TanDecimalNullableGroup : IOperator
{
    public TanDecimalNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
