using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>atan.decimal.nullable@group</c>.</summary>
public sealed record AtanDecimalNullableGroup : IOperator
{
    public AtanDecimalNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
