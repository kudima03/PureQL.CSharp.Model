using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asNullable.integer.nullable@group</c>.</summary>
public sealed record AsNullableIntegerNullableGroup : IOperator
{
    public AsNullableIntegerNullableGroup(IntegerGroup operand)
    {
        Operand = operand;
    }

    public IntegerGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
