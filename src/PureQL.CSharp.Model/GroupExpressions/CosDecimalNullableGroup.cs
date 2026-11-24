using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>cos.decimal.nullable@group</c>.</summary>
public sealed record CosDecimalNullableGroup : IOperator
{
    public CosDecimalNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
