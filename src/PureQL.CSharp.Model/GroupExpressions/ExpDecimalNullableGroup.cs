using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>exp.decimal.nullable@group</c>.</summary>
public sealed record ExpDecimalNullableGroup : IOperator
{
    public ExpDecimalNullableGroup(IntegerNullableOrDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
